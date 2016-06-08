using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MSMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ////.\MyQueue 本地私有队列   tech-wujc\MyQueue 公有网络队列
            //if (!MessageQueue.Exists(@".\MyQueue"))
            //{
            //    using (MessageQueue mq = MessageQueue.Create(@".\MyQueue"))
            //    {
            //        mq.Label = "test!";
            //        mq.Send("queue", "test!");
            //    }
            //}

            if (MessageQueue.Exists(@".\MyQueue"))
            {


                using (MessageQueue mq = new MessageQueue(@".\MyQueue"))
                {

                    mq.Formatter = new XmlMessageFormatter(new string[] { "System.String" });
                    Message ms = mq.Receive();

                    Console.WriteLine(ms.Body);
                }


            }

            Console.Read();

        }
    }
}
