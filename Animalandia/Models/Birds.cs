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
            ImageFilePath = "~/Content/Images/Animals/Birds/Parrot.png";
        }

        public override string Introduction()
        {
            return "Squawk! I'm Polly Parrot, and I can talk just like you. Want to hear me say hello?";
        }

        public override string Description()
        {
            return "Parrots are colorful birds that often have green, red, blue, or yellow feathers. They are known for their ability to mimic sounds and even talk. " +
                "Parrots have strong, curved beaks for cracking nuts and seeds. They are social birds that love to interact with people and other parrots. " +
                "Parrots are often found in tropical forests.";
        }
    }

    public class Eagle : Bird
    {
        public Eagle()
        {
            Name = "Eagle 🦅";
            SoundFilePath = "~/Content/Animal sounds/Birds/Eagle.mp3";
            ImageFilePath = "~/Content/Images/Animals/Birds/Eagle.png";
        }

        public override string Introduction()
        {
            return "Screech! I'm Eddie Eagle, and I fly high in the sky to see everything below!";
        }

        public override string Description()
        {
            return "Eagles are large, powerful birds with sharp talons and excellent eyesight. " +
                "They have brown feathers with white on their heads and tails, depending on the species. " +
                "Eagles are skilled hunters, catching fish and small animals with their strong claws. " +
                "They build large nests in high places and are symbols of strength and freedom.";
        }
    }

    public class Owl : Bird
    {
        public Owl()
        {
            Name = "Owl 🦉";
            SoundFilePath = "~/Content/Animal sounds/Birds/Owl.mp3";
            ImageFilePath = "~/Content/Images/Animals/Birds/Owl.png";
        }

        public override string Introduction()
        {
            return "Hoo hoo! I'm Ollie Owl, and I'm super smart. I stay awake at night to watch the stars!";
        }

        public override string Description()
        {
            return "Owls are mysterious, nocturnal birds with large, round eyes that can see in the dark. " +
                "They have soft feathers that help them fly silently. Owls come in many sizes and colors, but most are brown, gray, or white. " +
                "They are excellent hunters and eat small animals like mice and insects. Owls make a \"hoo-hoo\" sound, especially at night.";
        }
    }

    public class Penguin : Bird
    {
        public Penguin()
        {
            Name = "Penguin 🐧";
            SoundFilePath = "~/Content/Animal sounds/Birds/Penguin.mp3";
            ImageFilePath = "~/Content/Images/Animals/Birds/Penguin.png";
        }

        public override string Introduction()
        {
            return "Waddle waddle! I'm Penny Penguin. I love the cold and sliding on the ice with my belly!";
        }

        public override string Description()
        {
            return "Penguins are black-and-white birds that cannot fly but are amazing swimmers. " +
                "They live in cold regions like Antarctica and waddle on land with their short legs. " +
                "Penguins eat fish and krill and use their strong wings, called flippers, to dive into icy waters. " +
                "They are social animals that live in large groups for warmth and protection.";
        }
    }
}
