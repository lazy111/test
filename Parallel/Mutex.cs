using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M = System.Threading;

namespace Parallel
{
    //互斥锁。Mutex可用于进程内的线程同步，也可用于进程同步，一般用于进程同步。Monitor则只能用于进程内的线程同步。当进行进程内的线程同步时，优先选择Monitor。
    class Mutex
    {
        static void Main()
        {

            M.Thread t = new M.Thread(Run);
            t.Start();
            Console.Read();

        }

        static M.Mutex mutex = new M.Mutex(false, "mutex");  //未命名mutex仅存在在进程当中，已命名mutex在整个操作系统中可见，可用于同步进程活动

         static void Run()
        {

            mutex.WaitOne();
            Console.WriteLine("当前时间：{0}我是线程:{1}，我已经进去临界区", DateTime.Now, M.Thread.CurrentThread.GetHashCode());

            M.Thread.Sleep(10000);

            Console.WriteLine("\n当前时间:{0}我是线程:{1}，我准备退出临界区", DateTime.Now, M.Thread.CurrentThread.GetHashCode());

            mutex.ReleaseMutex();

        }

    }
}
