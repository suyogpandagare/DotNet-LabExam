using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WorkshopApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email,string pwd)
        {
            if(email.Equals("suyog@gmail.com") && pwd.Equals("suyog"))
            {
                FormsAuthentication.SetAuthCookie("Admin", true);
                return RedirectToAction("Index", "Tables");
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}