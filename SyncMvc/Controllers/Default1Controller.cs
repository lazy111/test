using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;

namespace SyncMvc.Controllers
{
    public class Default1Controller : System.Web.Mvc.AsyncController
    {
        //异步Action方法具有两种定义方式，一种是将其定义成两个匹配的方法XxxAsync/XxxCompleted，另一种则是定义一个返回类型为Task的方法。
        //异步操作主要用于I/O绑定操作（比如数据库访问和远程服务调用等），而非CPU绑定操作，因为异步操作对整体性能的提升来源于：当I/O设备在处理某个任务的时候，CPU可以释放出来处理另一个任务。如果耗时操作主要依赖于本机CPU的运算，采用异步方法反而会因为线程调度和线程上下文的切换而影响整体的性能。

        public void LoadAsync(string name)
        {

            /*
             
              public void IndexAsync()
              {
                AsyncManager.OutstandingOperations.Increment(2);//两个异步
                AsyncManager.Parameters["name"] = "objectboy"; 
           
                AsyncManager.OutstandingOperations.Decrement();

                AsyncManager.Parameters["age"] = "25";
                AsyncManager.OutstandingOperations.Decrement();
              }
              public ActionResult IndexCompleted(string name,string age)
              {
                return Content(name+age);
              }
             
             */

            //AsyncManager.OutstandingOperations.Increment();
            Task.Factory.StartNew(() =>
            {
                string path = ControllerContext.HttpContext.Server.MapPath(string.Format(@"~\html\{0}.html", name));
                using (StreamReader stream = new StreamReader(path))
                {
                    AsyncManager.Parameters["content"] = stream.ReadToEnd();  //在IO方法返回后，可以在AsyncManager.Parameters字典中保存希望传给ActionNameCompleted方法的参数。
                }


               // AsyncManager.OutstandingOperations.Decrement();//AsyncManager的OutstandingOperations属性的Increment和Decrement方法对于ASP.NET MVC发起通知
            });


        }
        public ActionResult LoadCompleted(string content)
        {
            return Content(content);

        }


    }
}
