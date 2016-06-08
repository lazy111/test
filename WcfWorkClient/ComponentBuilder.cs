using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace WcfWorkClient
{
    public static class ComponentBuilder
    {
        public static Object GetMessageFormatter(OperationDescription operation, bool isProxy)
        {
            DataContractSerializerOperationBehavior serializer = new DataContractSerializerOperationBehavior(operation);
            //我们调用操作行为DataContractSerializerOperationBehavior的GetFormatter方法来创建基于指定操作的消息格式化器。不过该方法是一个内部方法，所以我们是通过反射的方式来调用的。isProxy参数表示创建的是客户端消息格式化器（True）还是分发消息格式化器（False）。
            MethodInfo info = typeof(DataContractSerializerOperationBehavior).GetMethod("GetFormatter", BindingFlags.Instance | BindingFlags.NonPublic);
            return info.Invoke(serializer, new object[] { operation, false, false, isProxy });
        }

        public static MessageEncoderFactory GetMessageEncoderFactory()
        {
            TextMessageEncodingBindingElement bindingElement = new TextMessageEncodingBindingElement();
            return bindingElement.CreateMessageEncoderFactory();
        }

        public static IOperationInvoker GetOperationInvoker(MethodInfo method)
        {
            string syncMethodInvokerType = "System.ServiceModel.Dispatcher.SyncMethodInvoker, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
            Type type = Type.GetType(syncMethodInvokerType);
            return (IOperationInvoker)Activator.CreateInstance(type,new object[]{method});
        }
    }
}