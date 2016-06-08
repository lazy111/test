using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace WebApi2._0.Filters
{
    public class ActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            string msg = "BEFORE ACTION!";
            base.OnActionExecuting(actionContext);
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            string msg = "AFTER ACTION!";
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}