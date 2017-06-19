using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Web.Model;

namespace WebApi.Web.Controllers
{
    public class WebApiController : ApiController
    {

        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK, new Retorno() { Error = 0,  MsgError = "List", Object = new string[] { "value1", "value2" } }, Configuration.Formatters.JsonFormatter);
        }

        public IHttpActionResult Save()
        {
            return Content(HttpStatusCode.OK, new Retorno() { Error = 0, MsgError = "Save", Object = new string[] { "value1", "value2" } }, Configuration.Formatters.JsonFormatter);
        }
        public IHttpActionResult Remove()
        {
            return Content(HttpStatusCode.OK, new Retorno() { Error = 0, MsgError = "Remove", Object = new string[] { "value1", "value2" } }, Configuration.Formatters.JsonFormatter);
        }


    }
}
