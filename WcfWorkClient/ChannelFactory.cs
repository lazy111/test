using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace WcfWorkClient
{
    public class ChannelFactory<T>
    {
        public Uri Address { get; set; }
        public ChannelFactory(Uri address)
        {
            this.Address = address;
        }

        public T CreateChannel()
        {

            MessageEncoderFactory encoder = ComponentBuilder.GetMessageEncoderFactory();
            ChannelProxy<T> proxy = new ChannelProxy<T>(this.Address, MessageVersion.Default, encoder);

            ContractDescription cd = ContractDescription.GetContract(typeof(T));
            foreach (var item in cd.Operations)
            {
                IClientMessageFormatter messageFormatter = (IClientMessageFormatter)ComponentBuilder.GetMessageFormatter(item, true);
                proxy.MessageFormatter.Add(item.Name, messageFormatter);
            }

            return (T)proxy.GetTransparentProxy();

        }


    }
}
