using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// 共享数据,线程之间可以通过static变量来共享数据。
    /// </summary>
    class P5
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
                _isDone = true;
                Console.WriteLine("Done");//第二个线程来的时候，就不会再执行了(也不是绝对的，取决于计算机的CPU数量以及当时的运行情况)
            }

        }

    }
}
