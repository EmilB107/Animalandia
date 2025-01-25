using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Animalandia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ActivePage = "Home";
            ViewBag.FooterClass = "fixed-bottom";
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.ActivePage = "Gallery";
            ViewBag.FooterClass = ""; // No additional class for Gallery
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.ActivePage = "AboutUs";
            ViewBag.FooterClass = ""; // No additional class for About Us
            return View();
        }
    }
}
