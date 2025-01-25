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
            return "Dogs are loyal, friendly animals that come in many shapes, sizes, and colors. " +
                "They are known as \"man’s best friend\" because of their companionship and love for humans. " +
                "Dogs have a strong sense of smell and love to play, run, and wag their tails when happy. " +
                "They can be trained to do tricks and even help people by working as service animals. " +
                "Dogs eat a mix of meat, grains, and vegetables.";
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
            return "Cats are soft, independent pets with smooth fur that comes in many colors, such as white, black, orange, or gray. " +
                "They have sharp claws and whiskers and are known for being great hunters. Cats love to nap during the day and are very playful at night. " +
                "They make a purring sound when they are happy and enjoy climbing and scratching surfaces to keep their claws sharp.";
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
            return "Rabbits are small, fluffy animals with long ears and big back legs for hopping. " +
                "They have soft fur in colors like white, gray, brown, or black. Rabbits love to eat fresh vegetables, hay, and sometimes fruit as a treat. " +
                "They live in burrows or cozy spaces and enjoy playing with toys. Rabbits are quiet and gentle, making them wonderful pets for families.";
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
            return "FishFish are water-dwelling animals that come in all sorts of shapes, sizes, and bright colors. " +
                "Some fish are tiny, while others, like goldfish or clownfish, are popular pets. They have fins for swimming and gills to breathe underwater. " +
                "Fish love to explore their tank or pond and eat flakes or pellets made just for them. Watching fish swim can be very relaxing.";
        }
    }
}

