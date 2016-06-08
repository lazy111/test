using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy111
{
    public  class aa:IRunProxy
    {
        void IRunProxy.HowRun()
        {
            Console.WriteLine("aaaa");
        }
    }
}
