using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace WcfWorkService
{
    public class WcfHandler : IHttpHandler
    {
        public Type ServiceType { get; private set; }
        public IDictionary<string, MethodInfo> Methods { get; private set; }
        public MessageEncoderFactory MessageEncoderFactory { get; private set; }
        public IDictionary<string, IOperationInvoker> OperationInvokers { get; private set; }
        public IDictionary<string, IDispatchMessageFormatter> DispatchMessageFormatters { get; private set; }

        public bool IsReusable
        {
            get { return false; }
        }
        public WcfHandler(Type serviceType, MessageEncoderFactory messageEncoderFactory)
        {
            ServiceType = ServiceType;
            MessageEncoderFactory = messageEncoderFactory;
            Methods = new Dictionary<string, MethodInfo>();
            OperationInvokers = new Dictionary<string, IOperationInvoker>();
            DispatchMessageFormatters = new Dictionary<string, IDispatchMessageFormatter>();
        }

        public void ProcessRequest(HttpContext context)
        {
            Message request = this.MessageEncoderFactory.Encoder.ReadMessage(context.Request.InputStream, int.MaxValue, "application/soap+xml; charset=UTF-8");
            string action = request.Headers.Action;
            MethodInfo method = this.Methods[action];
            int outArgsCount = 0;
            foreach (var item in method.GetParameters())
            {
                if (item.IsOut)
                {
                    outArgsCount++;
                }
            }
            int inArgsCount = method.GetParameters().Count() - outArgsCount;
            object[] paramters = new object[inArgsCount];
            try
            {
                this.DispatchMessageFormatters[action].DeserializeRequest(request, paramters);
            }
            catch (Exception)
            {
                throw;
            }

            List<object> inArgs = new List<object>();
            object[] outArgs = new object[outArgsCount];
            //创建服务对象，在WCF中服务对象通过InstanceProvider创建
            object instance = Activator.CreateInstance(this.ServiceType);
            object result = this.OperationInvokers[action].Invoke(instance, paramters, out outArgs);
            Message reply = this.DispatchMessageFormatters[action].SerializeReply(request.Version, outArgs, result);
            this.MessageEncoderFactory.Encoder.WriteMessage(reply,context.Response.OutputStream);
            context.Response.Flush();

        }
    }
}