using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalandia.Models
{
    public class WildAnimal : Animal
    {
        public override string Introduction()
        {
            return "This is a wild animal.";
        }

        public override string Description()
        {
            return "Wild animals live in nature and are not domesticated.";
        }
    }

    public class Lion : WildAnimal
    {
        public Lion()
        {
            Name = "Lion 🦁";
            SoundFilePath = "~/Content/Animal sounds/Wild Animals/Lions.mp3";
            ImageFilePath = "~/Content/Images/Animals/Wild/Lion.png";
        }

        public override string Introduction()
        {
            return "Roar! I'm King Lion. I'm brave and strong, and I take care of my jungle kingdom!";
        }

        public override string Description()
        {
            return "Lions are big cats with golden fur and loud roars. Male lions have fluffy manes.";
        }
    }

    public class Elephant : WildAnimal
    {
        public Elephant()
        {
            Name = "Elephant 🐘";
            SoundFilePath = "~/Content/Animal sounds/Wild Animals/Elephant.mp3";
            ImageFilePath = "~/Content/Images/Animals/Wild/Elephant.png";
        }

        public override string Introduction()
        {
            return "Hello there! I'm Ellie Elephant, and I have a long trunk for hugs and squirting water!";
        }

        public override string Description()
        {
            return "Elephants are huge animals with gray skin, long trunks, and big ears.";
        }
    }

    public class Giraffe : WildAnimal
    {
        public Giraffe()
        {
            Name = "Giraffe 🦒";
            SoundFilePath = "~/Content/Animal sounds/Wild Animals/Giraffe.mp3";
            ImageFilePath = "~/Content/Images/Animals/Wild/Giraffe.png";
        }

        public override string Introduction()
        {
            return "Hi! I'm Gina Giraffe. My long neck helps me reach tasty leaves high in the trees!";
        }

        public override string Description()
        {
            return "Giraffes are tall animals with long necks and brown spots. They eat leaves from tall trees.";
        }
    }

    public class Zebra : WildAnimal
    {
        public Zebra()
        {
            Name = "Zebra 🦓";
            SoundFilePath = "~/Content/Animal sounds/Wild Animals/Zebra.mp3";
            ImageFilePath = "~/Content/Images/Animals/Wild/Zebra.png";
        }

        public override string Introduction()
        {
            return "Howdy! I'm Ziggy Zebra, and my black and white stripes are super cool, don't you think?";
        }

        public override string Description()
        {
            return "Zebras look like striped horses with black and white fur. They live in grassy areas.";
        }
    }
}
