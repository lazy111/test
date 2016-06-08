using IOCForMvc.Interface;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOCForMvc.Function
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        IKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IBookRepository>().To<BookRepository>();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
        public override void ReleaseController(IController controller)
        {
            if (kernel != null)
            {
                kernel.Release(controller);
            }
            else
            {
                base.ReleaseController(controller);
            }
        }
    }
}