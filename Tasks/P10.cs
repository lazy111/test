using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// async & wait
    /// </summary>
    class P10
    {
        static void Main()
        {
            Test();

            /*精辟：
             
             Test是被async声明的函数，如果Test内部没有await，则Test会被同步执行，如果有await，则执行到await会开辟一个新线程处理await等待的函数，然后将当前线程控制权返回给主函数Main
             
            */
            // 这个方法其实是多余的, 本来可以直接写下面的方法
            // await GetName() 
            // 但是由于控制台的入口方法不支持async,所有我们在入口方法里面不能 用 await
            Console.WriteLine("Current Thread Id :{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.Read();
        }


        static async void Test()
        {

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("first1");
            Console.WriteLine("Current Thread Id :{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            // 方法打上async关键字，就可以用await调用同样打上async的方法
            // await 后面的方法将在另外一个线程中执行
            await GetName();//await并不是针对于async的方法，而是针对async方法所返回给我们的Task，这也是为什么所有的async方法都必须返回给我们Task。所以我们同样可以在Task前面也加上await关键字
        }

        static async Task GetName()
        {
            await Task.Delay(1000);// 返回值前面加 async 之后，方法里面就可以用await了
            Console.WriteLine("Current Thread Id :{0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("In antoher thread.....");
        }
    }
}
