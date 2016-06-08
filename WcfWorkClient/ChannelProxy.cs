using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;
using System.Xml;

namespace WcfWorkClient
{
    public class ChannelProxy<TChannel> : RealProxy
    {
        public Uri Address { get; private set; }
        public MessageVersion MessageVersion { get; private set; }
        public IDictionary<string, IClientMessageFormatter> MessageFormatter { get; private set; }
        public MessageEncoderFactory MessageEncoderFactory { get; private set; }



        public ChannelProxy(Uri uri, MessageVersion mv, MessageEncoderFactory encoder)
            : base(typeof(TChannel))
        {

            this.Address = uri;
            this.MessageEncoderFactory = encoder;
            this.MessageVersion = mv;
            this.MessageFormatter = new Dictionary<string, IClientMessageFormatter>();

        }

        public override System.Runtime.Remoting.Messaging.IMessage Invoke(System.Runtime.Remoting.Messaging.IMessage msg)
        {
            IMethodCallMessage methodCall = (IMethodCallMessage)msg;
            //得到操作名称
            object[] attributes = methodCall.MethodBase.GetCustomAttributes(typeof(OperationContractAttribute), false);
            OperationContractAttribute attribute = attributes[0] as OperationContractAttribute;
            string operationName = string.IsNullOrEmpty(attribute.Name) ? methodCall.MethodName : attribute.Name;

            Message requestMessage = MessageFormatter[operationName].SerializeRequest(this.MessageVersion, methodCall.InArgs);

            EndpointAddress address = new EndpointAddress(this.Address);
            requestMessage.Headers.MessageId = new UniqueId(Guid.NewGuid());
            requestMessage.Headers.ReplyTo = new EndpointAddress("http://www.w3.org/2005/08/addressing/anonymous");
            address.ApplyTo(requestMessage);

            HttpWebRequest web = (HttpWebRequest)HttpWebRequest.Create(Address);
            web.Method = "Post";
            web.KeepAlive = true;
            web.ContentType = "application/soap+xml; charset=utf-8";


            ArraySegment<byte> bytes = this.MessageEncoderFactory.Encoder.WriteMessage(requestMessage, int.MaxValue, BufferManager.CreateBufferManager(long.MaxValue, int.MaxValue));

            web.ContentLength = bytes.Array.Length;
            web.GetRequestStream().Write(bytes.Array, 0, bytes.Array.Length);
            web.GetRequestStream().Close();
            WebResponse response = (WebResponse)web.GetResponse();

            //回复消息进行反列化生成相应的对象，并映射为方法调用的返回值或者ref/out参数
            object[] allArgs = (object[])Array.CreateInstance(typeof(object), methodCall.ArgCount);
            Array.Copy(methodCall.Args, allArgs, methodCall.ArgCount);
            Message responseMessage = this.MessageEncoderFactory.Encoder.ReadMessage(response.GetResponseStream(), int.MaxValue);
            object result = this.MessageFormatter[operationName].DeserializeReply(responseMessage, new object[GetRefOutParamterCount(methodCall.MethodBase)]);
            MapRefOutParameter(methodCall.MethodBase, allArgs, new object[GetRefOutParamterCount(methodCall.MethodBase)]);
            return new ReturnMessage(result, allArgs, allArgs.Length, methodCall.LogicalCallContext, methodCall);

        }

        private int GetRefOutParamterCount(MethodBase method)
        {
            ParameterInfo[] parameters = method.GetParameters();
            int count = 0;
            foreach (var item in parameters)
            {
                if (item.IsOut || item.ParameterType.IsByRef)
                {
                    count++;
                }

            }
            return count;
        }

        private void MapRefOutParameter(MethodBase method, object[] allArgs, object[] refOutArgs)
        {
            List<int> refOutParamPositionsList = new List<int>();
            foreach (ParameterInfo parameter in method.GetParameters())
            {
                if (parameter.IsOut || parameter.ParameterType.IsByRef)
                {
                    refOutParamPositionsList.Add(parameter.Position);
                }
            }
            int[] refOutParamPositionArray = refOutParamPositionsList.ToArray();
            for (int i = 0; i < refOutArgs.Length; i++)
            {
                allArgs[refOutParamPositionArray[i]] = refOutArgs[i];
            }
        }
    }
}