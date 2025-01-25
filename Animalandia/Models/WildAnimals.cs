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
            return "Lions are powerful and majestic big cats often called the \"king of the jungle.\" " +
                "They have golden fur, and male lions are easily recognized by their thick, fluffy manes. " +
                "Lions live in groups called prides, which include females and their cubs. " +
                "These animals are strong hunters and eat meat, usually catching animals like zebras or antelopes. " +
                "Their loud roar can be heard from miles away and is used to communicate with other lions.";
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
            return "Elephants are the largest land animals in the world, with thick gray skin, big ears, and long trunks. " +
                "They use their trunks for many things, like picking up food, drinking water, and even greeting other elephants. " +
                "Elephants have large tusks made of ivory and are known for their intelligence and strong family bonds. " +
                "They eat lots of plants, including grass, leaves, and fruit, and need plenty of water to stay hydrated.";
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
            return "Giraffes are the tallest animals on Earth, with long necks and legs that help them reach leaves high up in trees. " +
                "They have yellowish fur covered in unique brown spots, and no two giraffes have the same pattern. " +
                "Giraffes use their long tongues to grab leaves and twigs to eat. They live in savannas and open woodlands and can run surprisingly fast despite their size.";
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
            return "Zebras are horse-like animals with beautiful black-and-white stripes that make them stand out. " +
                "Each zebra has a unique stripe pattern, like a fingerprint. Zebras live in grassy areas and travel in herds to stay safe. " +
                "They eat grass and other plants and are always on the lookout for predators like lions. " +
                "Zebras are known for their loud braying sound, similar to a donkey’s.";
        }
    }
}
