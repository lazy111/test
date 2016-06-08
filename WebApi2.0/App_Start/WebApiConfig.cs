using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi2._0.Filters;

namespace WebApi2._0
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new ExceptionFilter());
            config.Filters.Add(new ActionFilter());
        }
    }
}
