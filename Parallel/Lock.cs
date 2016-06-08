using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel
{
    class Lock
    {

        static void t_Main()
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    Thread t = new Thread(Run);
            //    //Thread t = new Thread(Run2);
            //    t.Start();
            //}
            //Console.Read();


            John john = new John(obj);
            Jack jack = new Jack(obj);

            Thread johnThread = new Thread(john.Run);
            Thread jackThread = new Thread(jack.Run);

            johnThread.Name = "john";
            jackThread.Name = "jack";

            johnThread.Start();
            jackThread.Start();

            Console.ReadKey();






        }
        static int count;
        static object obj = new object();
        static void Run()
        {

            Monitor.Enter(obj);

            Thread.Sleep(10);

            Console.WriteLine("当前数字：{0}", ++count);

            Monitor.Exit(obj);

        }


        static void RunWithLock()
        {

            lock (obj)
            {
                Thread.Sleep(1000);

                Console.WriteLine("当前数字：{0}", ++count);

            }

        }
    }



    public class John
    {
        object obj;

        public John(object obj)
        {
            this.obj = obj;
        }

        public void Run()
        {

            Monitor.Enter(obj);

            Console.WriteLine("{0}:我已进入茅厕！", Thread.CurrentThread.Name);
            Console.WriteLine("{0}：擦，太臭了，我还是撤！", Thread.CurrentThread.Name);

            //暂时的释放锁资源
            Monitor.Wait(obj);
            Console.WriteLine("{0}：兄弟说的对，我还是进去吧。", Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            //唤醒等待队列中的线程
            Monitor.Pulse(obj);

            Console.WriteLine("{0}：拉完了，真舒服。", Thread.CurrentThread.Name);

            Monitor.Exit(obj);

        }

    }

    public class Jack
    {
        object obj;

        public Jack(object obj)
        {
            this.obj = obj;
        }

        public void Run()
        {
            Monitor.Enter(this.obj);

            Console.WriteLine("{0}:直奔茅厕，兄弟，你还是进来吧，小心憋坏了！", Thread.CurrentThread.Name);

            //唤醒等待队列中的线程
            Monitor.Pulse(this.obj);
            Thread.Sleep(1000);
            Console.WriteLine("{0}:哗啦啦....", Thread.CurrentThread.Name);

            //暂时的释放锁资源
            Monitor.Wait(this.obj);

            Console.WriteLine("{0}：拉完了,真舒服。", Thread.CurrentThread.Name);

            Monitor.Exit(this.obj);


        }



    }
}
