using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy111
{
    [Intercept("logger")]
    public class Person : IRun
    {
        public virtual void SayHello()
        {
            Console.WriteLine("hello!!");
        }

        public virtual void SayName(string pHometown)
        {
            Console.WriteLine("我是天涯人，我来自：{0}。", pHometown);
        }

        public void SayOther()
        {
            Console.WriteLine("是的，我是中国人。");
        }




        public void Run()
        {
            Console.WriteLine("两个腿跑！");
        }
    }
}
