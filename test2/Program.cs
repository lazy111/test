using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //test1

            /*
            FileStream fs = new FileStream(@"E:\SQLServer2012SP1-FullSlipstream-CHS-x64.iso", FileMode.Open);
            Byte[] bts = new Byte[61858764];
            fs.Read(bts, 0, bts.Length);
            Console.Write(System.Text.Encoding.Default.GetString(bts));
            Console.Read();
            */



            //test2

            //ClassA classa = new ClassA();

            //GC.Collect();            
            //GCNotificationStatus status= GC.WaitForFullGCComplete();
            //Console.WriteLine(status);



            MessageQueue queue = new MessageQueue(ConfigurationManager.AppSettings["MsmqPath"].ToString());
            queue.Receive(DateTime.Now - new DateTime(2016, 5, 25, 16, 00, 00) );
            Console.ReadKey();
        }
    }

    public class ClassA
    {
        ~ClassA()
        {
            Console.Write("dispose!");
        }
    }
}
