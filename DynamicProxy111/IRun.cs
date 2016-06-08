using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle;
using Autofac;
using Autofac.Configuration;
using Autofac.Core;
using Autofac.Extras.RegistrationAttributes;
using Autofac.Extras.DynamicProxy2;

namespace DynamicProxy111
{


    [Intercept("logger")]
    public interface IRun
    {
        void Run();

    }
}
