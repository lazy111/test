using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// 创建线程
    /// </summary>
    class P1
    {
        static void Main_temp(string[] args)
        {
            new Thread(Go).Start(); //.NET 1.0 
            Task.Factory.StartNew(Go); //.NET 4.0 TPL
            Task.Run(new Action(Go)); //.NET 4.5s
        }

        static void Go()
        {
            Console.Write("我是另一个线程！");
        }
    }
}
