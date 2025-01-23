using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalandia.Models
{
    public class AquaticAnimal : Animal
    {
        public override string Introduction()
        {
            return "This is an aquatic animal.";
        }

        public override string Description()
        {
            return "Aquatic animals live in water.";
        }
    }

    public class Dolphin : AquaticAnimal
    {
        public Dolphin()
        {
            Name = "Dolphin 🐬";
            SoundFilePath = "~/Content/Animal sounds/Aquatic/Dolphin.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Eee! I'm Dolly Dolphin, and I love jumping high and playing in the ocean waves!";
        }

        public override string Description()
        {
            return "Dolphins are friendly, gray animals that swim fast and love to jump out of water.";
        }
    }

    public class Shark : AquaticAnimal
    {
        public Shark()
        {
            Name = "Shark 🦈";
            SoundFilePath = "~/Content/Animal sounds/Aquatic/Shark (2).mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Hey there! I'm Sharky Shark. Don't worry, I'm just a big fish with a toothy grin!";
        }

        public override string Description()
        {
            return "Sharks are big fish with sharp teeth. They can be gray, blue, or even white.";
        }
    }

    public class Octopus : AquaticAnimal
    {
        public Octopus()
        {
            Name = "Octopus 🐙";
            SoundFilePath = "~/Content/Animal sounds/Aquatic/Shark (2).mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Hi! I'm Ollie Octopus, and I have eight arms for hugs and playing hide-and-seek!";
        }

        public override string Description()
        {
            return "Octopuses have soft, round bodies and eight arms. They can change color to hide.";
        }
    }
}
