using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{

    /// <summary>
    /// SemaphoreSlim 设置同一时间内允许一定数量的线程同时访问。
    /// </summary>
    class P8
    {

        static SemaphoreSlim _sem = new SemaphoreSlim(3);
        static void Main_temp()
        {

            for (int i = 1; i <= 5; i++) new Thread(Enter).Start(i);
            Console.ReadLine();
        }

        static void Enter(object id)
        {
            Console.WriteLine(id + " 开始排队...");
            _sem.Wait();
            Console.WriteLine(id + " 开始执行！");
            Thread.Sleep(1000 * (int)id);
            Console.WriteLine(id + " 执行完毕，离开！");
            _sem.Release();

        }
        //前3个排队之后就立即进入执行，但是4和5，只有等到有线程退出之后才可以执行。
    }
}
