using FeedBackSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeedBackSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Database1Entities db = new Database1Entities();
            
            return View();
        }

    }
}