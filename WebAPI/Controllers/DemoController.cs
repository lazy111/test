using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;
using System.Web.Routing;

namespace WebAPI.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            Configuration.Services.GetHttpControllerActivator();    //激活Controller
            Configuration.Services.GetHttpControllerSelector();     //匹配Controller
            Configuration.Services.GetHttpControllerTypeResolver(); //解析程序集
            Configuration.DependencyResolver.BeginScope();
            Request.GetDependencyScope().GetService(Configuration.Services.GetHttpControllerSelector().SelectController(Request).ControllerType);

            //HttpServer
            //DelegatingHandler


            return "Get";
        }
        public string Put()
        {
            return "Put";
        }
        public string Post()
        {
            return "Post";
        }
        public string Delete()
        {
            return "Delete";
        }
    }
}
