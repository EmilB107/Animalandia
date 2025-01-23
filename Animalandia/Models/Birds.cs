using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalandia.Models
{
    public class Bird : Animal
    {
        public override string Introduction()
        {
            return "This is a bird.";
        }

        public override string Description()
        {
            return "Birds are feathered, winged, egg-laying vertebrates.";
        }
    }

    public class Parrot : Bird
    {
        public Parrot()
        {
            Name = "Parrot 🦜";
            SoundFilePath = "~/Content/Animal sounds/Birds/parrot.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Squawk! I'm Polly Parrot, and I can talk just like you. Want to hear me say hello?";
        }

        public override string Description()
        {
            return "Parrots are colorful birds that can talk! They often have green, red, or blue feathers.";
        }
    }

    public class Eagle : Bird
    {
        public Eagle()
        {
            Name = "Eagle 🦅";
            SoundFilePath = "~/Content/Animal sounds/Birds/Eagle.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Screech! I'm Eddie Eagle, and I fly high in the sky to see everything below!";
        }

        public override string Description()
        {
            return "Eagles are large, powerful birds with brown and white feathers. They fly very high.";
        }
    }

    public class Owl : Bird
    {
        public Owl()
        {
            Name = "Owl 🦉";
            SoundFilePath = "~/Content/Animal sounds/Birds/Owl.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Hoo hoo! I'm Ollie Owl, and I'm super smart. I stay awake at night to watch the stars!";
        }

        public override string Description()
        {
            return "Owls are nighttime birds with big eyes and soft feathers. They hoot 'whoo-whoo!'";
        }
    }

    public class Penguin : Bird
    {
        public Penguin()
        {
            Name = "Penguin 🐧";
            SoundFilePath = "~/Content/Animal sounds/Birds/Penguin.mp3";
            ImageFilePath = "~/Content/Images/placeholder2.png";
        }

        public override string Introduction()
        {
            return "Waddle waddle! I'm Penny Penguin. I love the cold and sliding on the ice with my belly!";
        }

        public override string Description()
        {
            return "Penguins are black and white birds that waddle and swim. They live in cold places.";
        }
    }
}
