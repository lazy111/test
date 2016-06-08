using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using ServiceStack.Redis.Pipeline;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            //IRedisClient client = RedisManager.GetClient();
            //IRedisTypedClient<UserModel> userModelClient = client.GetTypedClient<UserModel>();

            //RedisClient rc = new RedisClient();

            Console.Write("IP:");
            string ipHost = Console.ReadLine();
            Console.Write("Port:");
            int port = Convert.ToInt32(Console.ReadLine());



            IRedisClient client = new RedisClient(ipHost, port);

            //ThreadPool.SetMaxThreads(10, 10);

            //while (true)
            //{
            //    ThreadPool.QueueUserWorkItem((o) =>
            //    {

            //        Console.WriteLine(client.Increment("i", 1));

            //        Interlocked.Increment(ref count);

            //    });
            //    if (count > 100)
            //    {
            //        break;
            //    }
            //}


            // client.SetEntryInHash("2016", "102", "holidays");




            //IRedisPipeline pl = client.CreatePipeline();


            //using (pl)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        int days = DateTime.DaysInMonth(2016, i);

            //        for (int j = 1; j <= days; j++)
            //        {
            //            //Console.WriteLine(BuildKey(i, j));
            //            pl.QueueCommand(c => ((RedisNativeClient)c).HDel("CarNumLimit_Config_2016", System.Text.Encoding.Default.GetBytes(BuildKey(i, j))));
            //        }

            //    }

            //    pl.Flush(); 


            //}

            RedisClient redisClient = new RedisClient();
            using (IRedisPipeline pipeline = redisClient.CreatePipeline())
            {
               // pipeline.QueueCommand(r=>r.ExecLuaAsString());



            }


            Console.ReadKey();


        }

    }


}
