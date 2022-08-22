using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Problem1.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Login()
        {
            return View();
        }

      
        [HttpPost]
        public ActionResult Login(string email, string password, string ReturnUrl)
        {
            if (email == "suyog@gmail.com" && password == "suyog")
            {
                FormsAuthentication.SetAuthCookie(email, false);
                return Redirect(ReturnUrl ?? Url.Action("Index", "Home"));
            }
            else
                return View();
        }

    }
}