using CCA.Common.Models.PostData.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CCA.Server.Controllers
{
    [RoutePrefix("register")]
    public class RegisterController : ApiController
    {
        [Route("checkemail")]
        [HttpPost]
        public IHttpActionResult CheckEmail(CheckEmailPostData pd)
        {
            return Json(DataManager.Register.CheckEmail(pd));
        }

        [Route("checkpassword")]
        [HttpPost]
        public IHttpActionResult CheckPassword(CheckPasswordPostData pd)
        {
            return Json(DataManager.Register.CheckPassword(pd));
        }
    }
}
