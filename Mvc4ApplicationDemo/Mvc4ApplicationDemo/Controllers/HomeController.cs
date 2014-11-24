using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4ApplicationDemo.Models;
namespace Mvc4ApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Careers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult submit(StudentsModel student)
        {
            if (ModelState.IsValid)
            {
                demoEntities Studententities = new demoEntities();
                //method to insert records
                tbl_Students std = new tbl_Students();
                std.studentFname= student.FirstName;
                std.studentlName= student.LastName;
                std.Skill= student.Skill;
                std.experience= student.Experience;
                std.qualification= student.Qualification;

                Studententities.tbl_Students.Add(std);
                if (Studententities.SaveChanges() > 0)
                    ViewData["Message"] = "sucess";
                else
                    ViewData["Message"] = "fail";

                    //return RedirectToAction("Index");
            }
           
         return View("Careers");
        }
        [HttpGet]
       public ActionResult Student()
        {



            return View();
        }
        //[HttpPost]
        //public ActionResult Student(FormCollection coll)
        //{
         


        //    return View();
        //}

        public ActionResult StudentDetails()
        {
            return View();
        }
        public ActionResult StudentsList()
        {
            return View();
        }
    }
}
