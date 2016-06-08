using IOCForMvc.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace IOCForMvc.Function
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        IKernel kernel;

        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        public IDependencyScope BeginScope()
        {
            return this;
        }


        private void AddBindings()
        {
            kernel.Bind<IBookRepository>().To<BookRepository>();
        }

        public object GetService(Type serviceType)
        {
            if (serviceType==null)
            {
                throw new ArgumentNullException();
            }

            return kernel.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return null;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}