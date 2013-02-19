using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internet.Controllers
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
            ViewBag.Message = "Canvas and SVG comparisons.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DeepDive()
        {
            ViewBag.Message = "Initial Deep Dive.";

            return View();
        }

        public ActionResult BasicVectorShapes()
        {
            ViewBag.Message = "Basic Vector Shapes.";

            return View();
        }

        public ActionResult Paths()
        {
            ViewBag.Message = "Paths.";

            return View();
        }
    }
}