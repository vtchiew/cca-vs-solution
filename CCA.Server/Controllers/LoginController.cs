using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCA.Server.Controllers
{
    [RoutePrefix("login")]
    public class LoginController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult Login()
        {
            return Json(new { text = "Haha" });
        }

        [Route("something")]
        [HttpGet]
        public IHttpActionResult Login2()
        {
            return Json(new { text = "something" });
        }
    }
}
