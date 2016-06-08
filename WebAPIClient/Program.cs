using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client1 = new HttpClient();
            HttpClient client2 = new HttpClient();
            HttpClient client3 = new HttpClient();
            HttpClient client4 = new HttpClient();

            client3.DefaultRequestHeaders.Add("X-HTTP-Method-Override", "PUT");
            client4.DefaultRequestHeaders.Add("X-HTTP-Method-Override", "DELETE");
            Console.WriteLine("{0,-7}{1,-24}{2,-6}", "Method", "X-HTTP-Method-Override", "Action");

            InvokeWebAPI(client1, HttpMethod.Get);
            InvokeWebAPI(client2, HttpMethod.Post);
            InvokeWebAPI(client3, HttpMethod.Post);
            InvokeWebAPI(client4, HttpMethod.Post);

            Console.Read();


        }
        async static void InvokeWebAPI(HttpClient client, HttpMethod method)
        {
            string requestUri = "http://localhost:29555/api/demo";
            HttpRequestMessage request = new HttpRequestMessage(method, requestUri);
            HttpResponseMessage response = await client.SendAsync(request);
            IEnumerable<string> methodsOverride;
            client.DefaultRequestHeaders.TryGetValues("X-HTTP-Method-Override", out methodsOverride);
            string actionName = response.Content.ReadAsStringAsync().Result;
            string methodOverride = methodsOverride == null ? "N/A" : methodsOverride.First();
            Console.WriteLine("{0,-7}{1,-24}{2,-6}", method, methodOverride, actionName.Trim('"'));

          
        }
    }
}
