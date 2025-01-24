using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalandia.Models
{
    public class Pet : Animal
    {
        public override string Introduction()
        {
            return "This is a pet.";
        }

        public override string Description()
        {
            return "Pets are animals that live with humans.";
        }
    }

    public class Dog : Pet
    {
        public Dog()
        {
            Name = "Dog 🐕";
            SoundFilePath = "~/Content/Animal sounds/Pets/Dog.mp3";
            ImageFilePath = "~/Content/Images/Animals/Pets/Dog.png";
        }

        public override string Introduction()
        {
            return "Woof woof! I'm Buddy the Dog. I love to play fetch and give big slobbery kisses!";
        }

        public override string Description()
        {
            return "Dogs are furry friends of many colors. They bark, wag their tails, and love to play fetch!";
        }
    }

    public class Cat : Pet
    {
        public Cat()
        {
            Name = "Cat 🐈";
            SoundFilePath = "~/Content/Animal sounds/Pets/Cat.mp3";
            ImageFilePath = "~/Content/Images/Animals/Pets/Cat.png";
        }

        public override string Introduction()
        {
            return "Meow! I'm Whiskers the Cat. I like to nap in sunny spots and chase little toys!";
        }

        public override string Description()
        {
            return "Cats are small, soft animals with whiskers. They purr when happy and come in many colors.";
        }
    }

    public class Rabbit : Pet
    {
        public Rabbit()
        {
            Name = "Rabbit 🐇";
            SoundFilePath = "~/Content/Animal sounds/Pets/Rabbit.mp3";
            ImageFilePath = "~/Content/Images/Animals/Pets/Rabbit.png";
        }

        public override string Introduction()
        {
            return "Hop hop! I'm Ruby Rabbit, and I munch on carrots all day. Let's bounce together!";
        }

        public override string Description()
        {
            return "Rabbits are fluffy with long ears and hop around. They love carrots and leafy greens!";
        }
    }

    public class Fish : Pet
    {
        public Fish()
        {
            Name = "Fish 🐟";
            SoundFilePath = "~/Content/Animal sounds/Pets/fish.mp3";
            ImageFilePath = "~/Content/Images/Animals/Pets/Fish.png";
        }

        public override string Introduction()
        {
            return "Glub glub! I'm Finn the Fish, and I love swimming all day in my bubbly water home!";
        }

        public override string Description()
        {
            return "Fish live in water and come in bright colors. They swim with fins and breathe through gills.";
        }
    }
}

