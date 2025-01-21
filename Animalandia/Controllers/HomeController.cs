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
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.ActivePage = "Gallery";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.ActivePage = "AboutUs";
            return View();
        }
    }
}