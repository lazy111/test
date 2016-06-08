using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;

namespace WebAPI.HttpHandler
{
    public class HttpRequestExtHandler : DelegatingHandler
    {
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
         
            return base.SendAsync(request, cancellationToken);
        }
    }
}