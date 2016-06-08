using Autofac;
using Autofac.Configuration;
using Castle.DynamicProxy;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy111
{
    class Program
    {
        private static IContainer container { get; set; }
        static void Main(string[] args)
        {

            //ProxyGenerator proxy = new ProxyGenerator();
            //Person person = proxy.CreateClassProxy<Person>(new SimpleInterceptor());

            //person.SayHello();
            //Console.ReadKey();


            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            container = builder.Build();

            IRun run = container.ResolveNamed<IRun>("dog");

            run.Run();
            
            //var builder = new ContainerBuilder();

            //builder.RegisterModule<RegisterModule>();
            //builder.RegisterModule(new ConfigurationSettingsReader("autofac"));

            //var container = builder.Build();

            //IRun run = container.Resolve<IRun>();

            //run.Run();

            //IRunProxy proxy=    container.Resolve<IRunProxy>();

            //IRunProxy proxy = container.Resolve(typeof(RunProxy)) as IRunProxy;

            //proxy.HowRun();

            //Student s = new Student();

            //Class2 c = new Class2();
            //ValidationResult vr = c.Validate(s);
            Console.ReadKey();

        }
    }
}
