using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfWorkService
{
    public class CalculatorService:ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}