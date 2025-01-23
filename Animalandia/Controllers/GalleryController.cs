using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Animalandia.Models;

namespace Animalandia.Controllers
{
    public class AnimalsController : Controller
    {
        public ActionResult FarmAnimals()
        {
            ViewBag.ActivePage = "FarmAnimals";
            ViewBag.ActiveSection = "Gallery";
            ViewBag.Title = "Farm Animals";

            List<Animal> farmAnimals = new List<Animal>
            {
                new Cow(),
                new Sheep(),
                new Pig(),
                new Chicken()
            };

            return View(farmAnimals);
        }

        public ActionResult WildAnimals()
        {
            ViewBag.ActivePage = "WildAnimals";
            ViewBag.ActiveSection = "Gallery";
            ViewBag.Title = "Wild Animals";

            List<Animal> wildAnimals = new List<Animal>
            {
                new Lion(),
                new Elephant(),
                new Giraffe(),
                new Zebra()
            };

            return View(wildAnimals);
        }

        public ActionResult Pets()
        {
            ViewBag.ActivePage = "Pets";
            ViewBag.ActiveSection = "Gallery";
            ViewBag.Title = "Pets";

            List<Animal> pets = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Rabbit(),
                new Fish()
            };

            return View(pets);
        }

        public ActionResult AquaticAnimals()
        {
            ViewBag.ActivePage = "AquaticAnimals";
            ViewBag.ActiveSection = "Gallery";
            ViewBag.Title = "Aquatic Animals";

            List<Animal> aquaticAnimals = new List<Animal>
            {
                new Dolphin(),
                new Shark(),
                new Octopus()
            };

            return View(aquaticAnimals);
        }

        public ActionResult Birds()
        {
            ViewBag.ActivePage = "Birds";
            ViewBag.ActiveSection = "Gallery";
            ViewBag.Title = "Birds";

            List<Animal> birds = new List<Animal>
            {
                new Parrot(),
                new Eagle(),
                new Owl(),
                new Penguin()
            };

            return View(birds);
        }

        public ActionResult Insects()
        {
            ViewBag.ActivePage = "Insects";
            ViewBag.ActiveSection = "Gallery";
            ViewBag.Title = "Insects";

            List<Animal> insects = new List<Animal>
            {
                new Butterfly(),
                new Bee(),
                new Ladybug(),
                new Ant()
            };

            return View(insects);
        }
    }
}


