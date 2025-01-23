using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalandia.Models
{
    public class Insect : Animal
    {
        public override string Introduction()
        {
            return "This is an insect.";
        }

        public override string Description()
        {
            return "Insects are small animals with six legs and usually wings.";
        }
    }

    public class Butterfly : Insect
    {
        public Butterfly()
        {
            Name = "Butterfly 🦋";
            SoundFilePath = "~/Content/Animal sounds/Insects/Butterfly.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Hi there! I'm Bella Butterfly. My wings are colorful, and I love fluttering in flowers!";
        }

        public override string Description()
        {
            return "Butterflies are small insects with colorful wings. They flutter from flower to flower.";
        }
    }

    public class Bee : Insect
    {
        public Bee()
        {
            Name = "Bee 🐝";
            SoundFilePath = "~/Content/Animal sounds/Insects/bee.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Bzz bzz! I'm Buzz Bee. I make honey and love visiting flowers for their sweet nectar!";
        }

        public override string Description()
        {
            return "Bees are yellow and black insects that make honey and buzz around flowers.";
        }
    }

    public class Ladybug : Insect
    {
        public Ladybug()
        {
            Name = "Ladybug 🐞";
            SoundFilePath = "~/Content/Animal sounds/Insects/ladybug.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Hello! I'm Lucy Ladybug. My red and black spots make me look fancy, don't you think?";
        }

        public override string Description()
        {
            return "Ladybugs are tiny red insects with black spots. They're fun to spot in gardens!";
        }
    }

    public class Ant : Insect
    {
        public Ant()
        {
            Name = "Ant 🐜";
            SoundFilePath = "~/Content/Animal sounds/Insects/ant.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Hi! I'm Andy Ant. I'm small but super strong, and I work hard with my ant friends!";
        }

        public override string Description()
        {
            return "Ants are small and hardworking insects that work together to build big nests.";
        }
    }
}

