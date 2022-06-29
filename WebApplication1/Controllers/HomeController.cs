using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculate;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "1", Text ="plus"},
                new SelectListItem() { Value = "2", Text ="minus" },
                new SelectListItem() { Value = "3", Text ="multiply" },
                new SelectListItem() { Value = "4", Text ="division" },
                new SelectListItem() { Value = "5", Text ="pow" },
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
            int op,
            double a,
            double b)
        {
            fCalc res = new fCalc();
            double result = res._bRavno_Click( a, b, op);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
 new SelectListItem() { Value = "1", Text ="plus" },
 new SelectListItem() { Value = "2", Text ="minus" },
 new SelectListItem() { Value = "3", Text ="multiply" },
 new SelectListItem() { Value = "4", Text ="division" },
 new SelectListItem() { Value = "5", Text ="pow" },
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

