using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalandia.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string SoundFilePath { get; set; }
        public string ImageFilePath { get; set; }

        public virtual string Introduction()
        {
            return "This is an animal.";
        }

        public virtual string Description()
        {
            return "Animals are multicellular, eukaryotic organisms of the kingdom Animalia.";
        }
    }
}
