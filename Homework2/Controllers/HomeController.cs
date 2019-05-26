using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string amount)
        {
            int digits = amount.Length;
            var realAmount = Convert.ToInt32(amount);
            var divResult = 0;
            var leftovers = 0;

            ViewBag.oneThousand = 0;
            ViewBag.fiveHundred = 0;
            ViewBag.oneHundred = 0;
            ViewBag.fifty = 0;
            ViewBag.ten = 0;
            ViewBag.five = 0;
            ViewBag.one = 0;

            if (digits >= 4)
            {
                divResult = (int) Math.Floor((double)realAmount / 1000);
                leftovers = realAmount - (divResult * 1000);

                ViewBag.oneThousand = divResult;

                if (leftovers >= 500)
                {
                    divResult = (int)Math.Floor((double)leftovers / 500);
                    leftovers = leftovers - (divResult * 500);

                    ViewBag.fiveHundred = divResult;
                }
                if (leftovers >= 100)
                {
                    divResult = (int)Math.Floor((double)leftovers / 100);
                    leftovers = leftovers - (divResult * 100);

                    ViewBag.oneHundred = divResult;
                }
                if (leftovers >= 50)
                {
                    divResult = (int)Math.Floor((double)leftovers / 50);
                    leftovers = leftovers - (divResult * 50);

                    ViewBag.fifty = divResult;
                }
                if (leftovers >= 10)
                {
                    divResult = (int)Math.Floor((double)leftovers / 10);
                    leftovers = leftovers - (divResult * 10);

                    ViewBag.ten = divResult;
                }
                if (leftovers >= 5)
                {
                    divResult = (int)Math.Floor((double)leftovers / 5);
                    leftovers = leftovers - (divResult * 5);

                    ViewBag.five = divResult;
                }
                if (leftovers >= 1) 
                {
                    divResult = (int)Math.Floor((double)leftovers / 1);
                    leftovers = leftovers - (divResult * 1);

                    ViewBag.one = divResult;
                }
            }

            if (digits == 3)
            {
                divResult = (int)Math.Floor((double)realAmount / 500);
                leftovers = realAmount - (divResult * 500);

                ViewBag.fiveHundred = divResult;
                
                if (leftovers >= 100)
                {
                    divResult = (int)Math.Floor((double)leftovers / 100);
                    leftovers = leftovers - (divResult * 100);

                    ViewBag.oneHundred = divResult;
                }
                else if (leftovers >= 50)
                {
                    divResult = (int)Math.Floor((double)leftovers / 50);
                    leftovers = leftovers - (divResult * 50);

                    ViewBag.fifty = divResult;
                }
                else if (leftovers >= 10)
                {
                    divResult = (int)Math.Floor((double)leftovers / 10);
                    leftovers = leftovers - (divResult * 10);

                    ViewBag.ten = divResult;
                }
                else if (leftovers >= 5)
                {
                    divResult = (int)Math.Floor((double)leftovers / 5);
                    leftovers = leftovers - (divResult * 5);

                    ViewBag.five = divResult;
                }
                else
                {
                    divResult = (int)Math.Floor((double)leftovers / 1);
                    leftovers = leftovers - (divResult * 1);

                    ViewBag.one = divResult;
                }
            }

            if (digits == 2)
            {
                divResult = (int)Math.Floor((double)realAmount / 50);
                leftovers = realAmount - (divResult * 50);

                ViewBag.fifty = divResult;

                if (leftovers >= 10)
                {
                    divResult = (int)Math.Floor((double)leftovers / 10);
                    leftovers = leftovers - (divResult * 10);

                    ViewBag.ten = divResult;
                }
                else if (leftovers >= 5)
                {
                    divResult = (int)Math.Floor((double)leftovers / 5);
                    leftovers = leftovers - (divResult * 5);

                    ViewBag.five = divResult;
                }
                else
                {
                    divResult = (int)Math.Floor((double)leftovers / 1);
                    leftovers = leftovers - (divResult * 1);

                    ViewBag.one = divResult;
                }
            }

            if (digits == 1)
            {
                divResult = (int)Math.Floor((double)realAmount / 5);
                leftovers = realAmount - (divResult * 5);

                ViewBag.five = divResult;

                if (leftovers >= 1)
                {
                    divResult = (int)Math.Floor((double)leftovers / 1);
                    leftovers = leftovers - (divResult * 1);

                    ViewBag.one = divResult;
                }
                
            }

            return View();
            
        }
    }
}