using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Animalandia.Controllers
{
    public class AnimalsController : Controller
    {
        public ActionResult FarmAnimals()
        {
            ViewBag.ActivePage = "FarmAnimals";
            ViewBag.ActiveSection = "Gallery";
            return View();
        }

        public ActionResult WildAnimals()
        {
            ViewBag.ActivePage = "WildAnimals";
            ViewBag.ActiveSection = "Gallery";
            return View();
        }

        public ActionResult Pets()
        {
            ViewBag.ActivePage = "Pets";
            ViewBag.ActiveSection = "Gallery";
            return View();
        }

        public ActionResult AquaticAnimals()
        {
            ViewBag.ActivePage = "AquaticAnimals";
            ViewBag.ActiveSection = "Gallery";
            return View();
        }

        public ActionResult Birds()
        {
            ViewBag.ActivePage = "Birds";
            ViewBag.ActiveSection = "Gallery";
            return View();
        }

        public ActionResult Insects()
        {
            ViewBag.ActivePage = "Insects";
            ViewBag.ActiveSection = "Gallery";
            return View();
        }
    }
}
