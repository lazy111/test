using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooKeeperNet;


namespace Zookeeper
{

    //zookeeper之配置管理
    class Program
    {
        static void Main(string[] args)
        {

            #region 配置管理
            //Config.StartConfig();

            //Client client = new Client();

            //while (true)
            //{
            //    Console.WriteLine(client.Username);
            //    Console.WriteLine(client.Password);

            //    Console.WriteLine("输出成功！");
            //    Thread.Sleep(3000);    
            //}
            #endregion


            #region 锁


            LockFactory.ServerHost = Console.ReadLine();


            while (LockFactory.CreateLock() == null)
            {

                Console.WriteLine("try get lock!");

            }

            Thread.Sleep(20000);
            LockFactory.ReleaseLock();
            Console.Write("exec over!");


            #endregion
            Console.ReadKey();
        }
    }
}
