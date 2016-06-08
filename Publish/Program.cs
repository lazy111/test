using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject dog = new Dog();
            IPublish cat = new Cat();
            IPublish human = new Human();
            dog.Add(cat);
            dog.Add(human);
            dog.Notify();
            Console.ReadKey();

        }
    }
}
