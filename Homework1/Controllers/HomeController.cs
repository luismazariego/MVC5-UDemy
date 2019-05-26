using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string arg)
        {
            switch (arg)
            {
                case "sample.pdf":
                    return File("Sample.pdf", "application/pdf");
                case "gotoabout":
                    return RedirectToAction("About");
                case "login":
                    return View("Login");
                default:
                    return Content("You Entered: " + arg);
            }
            
        }

        public ActionResult About()
        {
            return Content("About content here");
        }
    }
}