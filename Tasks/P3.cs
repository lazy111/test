using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// 传入参数
    /// </summary>
    class P3
    {

        static void Main_temp()
        {
            new Thread(Go).Start(null); // // 没有匿名委托之前，我们只能这样传入一个object的参数
            new Thread(delegate()
            {
                TODO("arg1", "arg2", "arg3");
            });//有了匿名委托之后,我们可以传入多个参数

            new Thread(() =>
            {
                TODO("arg1", "arg2", "arg3");
            });//Lambada形式

            Task.Run(() =>
            {
                TODO("arg1", "arg2", "arg3");
            });
        }

        static void Go(object data)
        {
            //TODO
        }
        static void TODO(string arg1, string arg2, string arg3)
        {
            //TODO
        }

    }

}
