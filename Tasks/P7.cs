using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// 锁  锁的类型有独占锁，互斥锁，以及读写锁等
    /// </summary>
    class P7
    {
        static bool _isDone = false;
        static object _lock = new object();
        static ReaderWriterLock _rwlock = new ReaderWriterLock();
        static void Main_temp()
        {
            //要解决线程不安全的问题，我们就要用锁，这里使用独占锁

            new Thread(Done).Start();
            new Thread(Done).Start();
            Console.ReadKey();
            /*
            _rwlock.AcquireReaderLock(new TimeSpan());//读锁可以和其他的读锁兼容
            _rwlock.AcquireWriterLock(new TimeSpan());//写锁是一个完全排他锁。
            */

        }
        static void Done()
        {
            //加上锁之后，被锁住的代码在同一个时间内只允许一个线程访问，其它的线程会被阻塞，只有等到这个锁被释放之后其它的线程才能执行被锁住的代码。
            lock (_lock)
            {
                if (!_isDone)   
                {
                    Console.WriteLine("Done");
                    _isDone = true;
                }
            }
        }
    }
}
