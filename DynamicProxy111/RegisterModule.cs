using Autofac;
using Autofac.Extras.RegistrationAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy111
{
    public class RegisterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<Person>().Keyed<IRun>("person");
            //builder.RegisterType<Dog>().Keyed<IRun>("dog");
            //builder.Register(r => new RunProxy(
            //    r.ResolveKeyed<IRun>("dog")
            //)).As<IRunProxy>();



            builder.RegisterType<Person>().As<IRun>();
            builder.RegisterType<RunProxy>();

            

            //builder.RegisterType<RunProxy>().As<IRunProxy>();
           
        }

    }
}
