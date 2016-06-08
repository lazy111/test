using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace WcfWorkService
{
    public class WcfHttpModule : IHttpModule
    {
        public void Dispose()
        { }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            string relativeAddress = HttpContext.Current.Request.AppRelativeCurrentExecutionFilePath.Remove(0, 2);
            Type serviceType = RouteTable.Routes.Find(relativeAddress);
            if (null == serviceType)
            {
                return;
            }
            HttpContext.Current.RemapHandler(CreateHandler(serviceType));
          
        }

        IHttpHandler CreateHandler(Type serviceType)
        {
            MessageEncoderFactory encoder = ComponentBuilder.GetMessageEncoderFactory();
            WcfHandler handler = new WcfHandler(serviceType, encoder);
            Type interfaceType = serviceType.GetInterfaces()[0];
            ContractDescription contract = ContractDescription.GetContract(interfaceType);
            foreach (var item in contract.Operations)
            {
                IDispatchMessageFormatter formatter = (IDispatchMessageFormatter)ComponentBuilder.GetMessageFormatter(item, false);
                IOperationInvoker invoker = ComponentBuilder.GetOperationInvoker(item.SyncMethod);
                handler.DispatchMessageFormatters.Add(item.Messages[0].Action, formatter);
                handler.OperationInvokers.Add(item.Messages[0].Action, invoker);
                handler.Methods.Add(item.Messages[0].Action, item.SyncMethod);
            }
            return handler;
        }
    }
}