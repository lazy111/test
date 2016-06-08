using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// 线程安全
    /// </summary>
    class P6
    {
        static bool _isDone = false;

        static void Main_temp()
        {

            new Thread(Done).Start();
            new Thread(Done).Start();
            Thread.Sleep(5000);

        }

        static void Done()
        {
            if (!_isDone)
            {
                Console.WriteLine("Done");
                _isDone = true;
            }

        }
        //有时会输出DONE两次，第一个线程还没有来得及把_isDone设置成true，第二个线程就进来了，而这不是我们想要的结果，在多个线程下，结果不是我们的预期结果，这就是线程不安全。
    }
}
