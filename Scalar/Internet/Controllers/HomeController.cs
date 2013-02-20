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

        #region Chapter 1
        public ActionResult DeepDive()
        {
            ViewBag.Message = "Initial Deep Dive.";

            return View();
        }
        #endregion

        #region Chapter 2
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

        public ActionResult ReuseAndPatterns()
        {
            ViewBag.Message = "Reusing Graphics and Creating Patterns.";

            return View();
        }

        public ActionResult CaseStudy()
        {
            ViewBag.Message = "Case Study - Designing a Reusable Pattern.";

            return View();
        }
        #endregion

        #region Chapter 3
        public ActionResult Text()
        {
            ViewBag.Message = "Text.";

            return View();
        }
        #endregion
    }
}