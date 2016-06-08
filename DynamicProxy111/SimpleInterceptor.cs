using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy111
{
    public class SimpleInterceptor : StandardInterceptor  
    {
        protected override void PreProceed(IInvocation invocation)
        {
            Console.WriteLine("调用前的拦截器，方法名是：{0}。", invocation.Method.Name);  
            base.PreProceed(invocation);
        }
    }
}