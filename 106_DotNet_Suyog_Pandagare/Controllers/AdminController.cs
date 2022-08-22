using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ValuesController vc = new ValuesController();
        // GET: Admin
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(string name,DateTime date,string module,string faculty,int pbskills,int prskills)
        {
           
            StudentEntity st1 = new StudentEntity { Name = name,  Date=date , Module=module,Faculty=faculty,Prskills=prskills,Pbskills=pbskills };
           
            vc.Post(st1);
            return RedirectToAction("index","home");




        }

        


    }
}