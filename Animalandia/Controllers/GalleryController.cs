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
            return View();
        }

        public ActionResult WildAnimals()
        {
            return View();
        }

        public ActionResult Pets()
        {
            return View();
        }

        public ActionResult AquaticAnimals()
        {
            return View();
        }

        public ActionResult Birds()
        {
            return View();
        }

        public ActionResult Insects()
        {
            return View();
        }
    }
}