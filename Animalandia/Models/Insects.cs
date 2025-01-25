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
            ImageFilePath = "~/Content/Images/Animals/Insects/Butterfly.png";
        }

        public override string Introduction()
        {
            return "Hi there! I'm Bella Butterfly. My wings are colorful, and I love fluttering in flowers!";
        }

        public override string Description()
        {
            return "Butterflies are delicate insects with colorful, patterned wings. " +
                "They start life as caterpillars before transforming into butterflies through a process called metamorphosis. " +
                "Butterflies love to sip nectar from flowers and are important pollinators. " +
                "They are found in gardens, forests, and fields and come in many beautiful colors and shapes.";
        }
    }

    public class Bee : Insect
    {
        public Bee()
        {
            Name = "Bee 🐝";
            SoundFilePath = "~/Content/Animal sounds/Insects/bee.mp3";
            ImageFilePath = "~/Content/Images/Animals/Insects/Bee.png";
        }

        public override string Introduction()
        {
            return "Bzz bzz! I'm Buzz Bee. I make honey and love visiting flowers for their sweet nectar!";
        }

        public override string Description()
        {
            return "Bees are small, hardworking insects with black-and-yellow stripes. They buzz from flower to flower, collecting nectar to make honey. " +
                "Bees are very important for pollination, helping plants grow fruits and seeds. They live in colonies with a queen bee, worker bees, and drones. " +
                "Bees communicate through special dances to share the location of flowers.";
        }
    }

    public class Ladybug : Insect
    {
        public Ladybug()
        {
            Name = "Ladybug 🐞";
            SoundFilePath = "~/Content/Animal sounds/Insects/ladybug.mp3";
            ImageFilePath = "~/Content/Images/Animals/Insects/Ladybug.png";
        }

        public override string Introduction()
        {
            return "Hello! I'm Lucy Ladybug. My red and black spots make me look fancy, don't you think?";
        }

        public override string Description()
        {
            return "Ladybugs are tiny, round insects with shiny red or orange shells covered in black spots. " +
                "They are often seen in gardens and are helpful because they eat pests like aphids. " +
                "Ladybugs can also fly short distances and are a favorite insect of many kids because of their cute appearance.";
        }
    }

    public class Ant : Insect
    {
        public Ant()
        {
            Name = "Ant 🐜";
            SoundFilePath = "~/Content/Animal sounds/Insects/ant.mp3";
            ImageFilePath = "~/Content/Images/Animals/Insects/Ant.png";
        }

        public override string Introduction()
        {
            return "Hi! I'm Andy Ant. I'm small but super strong, and I work hard with my ant friends!";
        }

        public override string Description()
        {
            return "Ants are small insects that live and work in large groups called colonies. " +
                "They can be black, red, or brown and are known for being very strong for their size. " +
                "Ants build intricate underground homes and work together to find food and protect their queen. " +
                "They communicate using chemicals called pheromones to guide each other.";
        }
    }
}

