using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        ValuesController vc = new ValuesController();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
           
            return View();
        }


        public ActionResult Students()
        {
            List<StudentEntity> std1 = (List<StudentEntity>)vc.Get();
            this.ViewBag.Students = std1;
            return View();

        }
      




    }
}
