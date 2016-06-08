using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfWorkService;

namespace WcfWorkClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<ICalculator> factory = new ChannelFactory<ICalculator>(new Uri("http://localhost:22828/calculatorservice"));
            ICalculator calculator = factory.CreateChannel();
            int result = calculator.Add(1, 1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
