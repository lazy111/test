using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOCForMvc.Controllers
{
    public class DependencyController : Controller
    {
        //
        // GET: /Dependency/

        public ActionResult Index()
        {


            //IControllerFactory
            return View();
        }

    }
}
