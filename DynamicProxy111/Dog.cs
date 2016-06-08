using Autofac.Extras.DynamicProxy2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy111
{
    [Intercept("logger")]
    public class Dog:IRun
    {
        public IRunProxy R { get; set; }
        private string name;
        public Dog(string name, IRunProxy r)
        {
           this.name = name;
           this.R = r;
        }
        public void Run()
        {
            R.HowRun();
            Console.WriteLine(name+":四条腿跑");
        }
    }
}
