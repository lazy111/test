using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebAPI.HttpHandler
{

    public class HttpMethodOverrideHandler : DelegatingHandler
    {
        /// <summary>
        /// 继承DelegatingHandler对HTTP请求管道添加操作，重写HTTP请求方法
        /// </summary>

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