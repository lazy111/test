using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// 线程池 ,线程池是为突然大量爆发的线程设计的，通过有限的几个固定线程为大量的操作服务，减少了创建和销毁线程所需的时间，从而提高效率。默认开启25个空线程
    /// </summary>
    class P2
    {
        //线程的创建是比较占用资源的一件事情，.NET 为我们提供了线程池来帮助我们创建和管理线程。
        //Task是默认会直接使用线程池，但是Thread不会。如果我们不使用Task，又想用线程池的话，可以使用ThreadPool类。
        static void Main_temp()
        {
            Console.WriteLine("我是主线程：Thread ID {0}", Thread.CurrentThread.ManagedThreadId);
            ThreadPool.QueueUserWorkItem(Go);
            Console.ReadKey();

        }

        static void Go(object data)
        {
            Console.WriteLine("我是另一个线程：Thread ID {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
