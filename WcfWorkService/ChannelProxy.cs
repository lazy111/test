using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace WcfWorkService
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

        }

    }
}