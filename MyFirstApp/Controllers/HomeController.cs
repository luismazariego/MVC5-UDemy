using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[]
            {
                new {EmpId = 1, EmpName = "Scott", Salary = 8000},
                new {EmpId = 1, EmpName = "Smith", Salary = 2540},
                new {EmpId = 1, EmpName = "Allen", Salary = 9400},
            };
            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            //return new ContentResult(){ Content = matchEmpName, ContentType = "text/plain"};
            return Content(matchEmpName, "text/plain");
        }

        public ActionResult GetPaySlip(int EmpId)
        {
            string fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
            //return View();
        }

        public ActionResult EmpFacebookPage(int EmpId)
        {
            var employees = new[]
            {
                new {EmpId = 1, EmpName = "Scott", Salary = 8000},
                new {EmpId = 1, EmpName = "Smith", Salary = 2540},
                new {EmpId = 1, EmpName = "Allen", Salary = 9400},
            };

            string fbUrl = null;

            foreach (var item in employees)
            {
                if(item.EmpId == EmpId)
                    fbUrl = "http://www.facebook.com/emp" + EmpId;
            }

            if (fbUrl == null)
                return Content("Invalid employee id");

            return Redirect(fbUrl);
        }

        public ActionResult StudentDetails()
        {
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Scott";
            ViewBag.Marks = 50;
            ViewBag.NoOfSemesters = 6;
            ViewBag.Subjects = new List<string>() {"Math", "Physics", "Chemistry"};
            return View();
        }
    }
}