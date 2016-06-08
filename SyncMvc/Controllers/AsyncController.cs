using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SyncMvc.Controllers
{
    public class AsyncController : Controller
    {
        //
        // GET: /Async/

        public Task<ActionResult> Index(string name)
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(4000);
                string path = ControllerContext.HttpContext.Server.MapPath(string.Format(@"~\html\{0}.html", name));
                using (StreamReader stream = new StreamReader(path))
                {
                    AsyncManager.Parameters["content"] = stream.ReadToEnd(); //在IO方法返回后，可以在AsyncManager.Parameters字典中保存希望传给ActionNameCompleted方法的参数。
                }

            }).ContinueWith<ActionResult>((task) =>
            {
                return Content(AsyncManager.Parameters["content"].ToString());
            });
        }

        public Task<ActionResult> Index2(string name)
        {

            return Task.Factory.StartNew<string>(() =>
            {
                string path = ControllerContext.HttpContext.Server.MapPath(string.Format(@"~\html\{0}.html", name));
                using (StreamReader stream = new StreamReader(path))
                {
                    return stream.ReadToEnd();
                }
            }).ContinueWith<ActionResult>(task =>
            {

                return Content(task.Result);

            });


        }

        async void aa()
        {

            await Task.Run(() =>
             {
                 Thread.Sleep(1000);
             });

        }
    }
}
