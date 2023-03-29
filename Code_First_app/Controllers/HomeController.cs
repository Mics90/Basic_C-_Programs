using Code_First_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_app.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            return View();
        }

       
    }
}