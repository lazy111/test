using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace WebApi2._0.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {

            Exception ex = actionExecutedContext.Exception;

            string msg = ex.Message;
            
            base.OnException(actionExecutedContext);
        }
    }
}