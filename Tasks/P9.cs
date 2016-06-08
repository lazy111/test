using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class P9
    {
        /// <summary>
        /// 异常处理
        /// </summary>
        static void Main_temp()
        {

            //try
            //{
            //    new Thread(Go).Start();
            //}
            //catch (Exception)
            //{
            //    // 其它线程里面的异常，我们这里面是捕获不到的。
            //    Console.WriteLine("Exception!");
            //}
            try
            {
                var task = Task.Run(() => { Go(); });
                task.Wait();// 在调用了这句话之后，主线程才能捕获task里面的异常


                // 对于有返回值的Task, 我们接收了它的返回值就不需要再调用Wait方法了
                // GetName 里面的异常我们也可以捕获到
                var task2 = Task.Run(() => { return GetName(); });
                Console.WriteLine(task2.Result);

            }
            catch (Exception)
            {
                Console.WriteLine("Exception!");
            }



            Console.ReadLine();

        }

        static void Go() { throw null; }
        static string GetName() { throw null; }
    }
}
