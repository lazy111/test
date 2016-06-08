using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net;
using System.Net.Http.Formatting;

namespace WebAPI
{
    public static class WebApiConfig
    {

       
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.MediaTypeMappings.Add(new UriPathExtensionMapping("json", "application/json"));
            config.Formatters.XmlFormatter.MediaTypeMappings.Add(new UriPathExtensionMapping("xml", "application/xml"));
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            //config.Routes.MapHttpRoute(
            //    name: "IPAddressApi",
            //    routeTemplate: "{controller}/{id}",
            //    defaults: new { id = 1 }
            //);
            config.Routes.MapHttpRoute(
                name: "DemoApi",
                routeTemplate: "{controller}/{action}.{ext}"
            );
        }
    }
}
