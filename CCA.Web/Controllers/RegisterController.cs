using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CCA.Web.HttpHelper;
using System.Threading.Tasks;

namespace CCA.Web.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        async public Task<ActionResult> CheckEmail(string email)
        {
            return Json(await Register.CheckEmail(email));
        }

        async public Task<ActionResult> CheckPassword(string pwd)
        {
            return Json(await Register.CheckPassword(pwd));
        }
    }
}