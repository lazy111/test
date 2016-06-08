using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
namespace WebApiSeflHost
{
    //与WCF 类似，寄宿Web API 不一定需要IIS 的支持，我们可以采用Self Host 的方式使用任意类型的应用程序（控制台、Windows Forms 应用、WPF 应用甚至是Windows Service）作为宿主。
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly.Load("WebAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");  

            var config = new HttpSelfHostConfiguration("http://127.0.0.1:8080");
            config.Routes.MapHttpRoute(
                name: "SelfHost",
                routeTemplate: "api/{controller}/{action}"

            );

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.Write("Press Enter to quit.");
                Console.ReadKey();
            }

        }
    }
}
