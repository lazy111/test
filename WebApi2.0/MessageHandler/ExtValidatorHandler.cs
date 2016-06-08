using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebApi2._0.MessageHandler
{
    public class ExtValidatorHandler : DelegatingHandler
    {
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            IEnumerable<string> methodOverrideHandler;
            if (request.Headers.TryGetValues("X-HTTP-Method-Override", out methodOverrideHandler))
            {
                request.Method = new HttpMethod(methodOverrideHandler.First());
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}