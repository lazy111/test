using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub
{
    public  class Human:IPublish
    {
        public void ToDo()
        {
            Console.WriteLine("wake up!");
        }
    }
}
