using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApi.Web.Controllers
{
    public class CustomXmlResult : IHttpActionResult
    {
        private readonly string value;

        public CustomXmlResult(object obj)
        {
            value = JsonConvert.SerializeObject(obj);
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var content = new StringContent(value);
            content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = content };
            return Task.FromResult(response);
        }
    }
}