using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animalandia.Models
{
    public class FarmAnimal : Animal
    {
        public override string Introduction()
        {
            return "This is a farm animal.";
        }

        public override string Description()
        {
            return "Farm animals are domesticated animals raised for agricultural purposes.";
        }
    }

    public class Cow : FarmAnimal
    {
        public Cow()
        {
            Name = "Cow 🐄";
            SoundFilePath = "~/Content/Animal sounds/Farm Animals/Cows.mp3";
            ImageFilePath = "~/Content/Images/Animals/Farm/Cow.png";
        }

        public override string Introduction()
        {
            return "Moo! I'm Mrs. Cow, and I make yummy milk for everyone. I love munching on green grass!";
        }

        public override string Description()
        {
            return "Cows are large farm animals known for their gentle nature. They are often found in shades of black, white, brown, or a mix of these colors. " +
                "Cows have a strong, sturdy body, a big nose, and a long tail with a tuft of hair at the end. " +
                "They love to graze on grass and are known for producing milk, which is used to make cheese, butter, and yogurt. " +
                "Cows are social animals and often stay in herds. You can hear them saying \"moo\" in the fields.";
        }
    }

    public class Pig : FarmAnimal
    {
        public Pig()
        {
            Name = "Pig 🐖";
            SoundFilePath = "~/Content/Animal sounds/Farm Animals/Pigs.mp3";
            ImageFilePath = "~/Content/Images/Animals/Farm/Pig.png";
        }

        public override string Introduction()
        {
            return "Oink oink! I'm Piggy, and I adore rolling in the mud—it keeps me cool and happy!";
        }

        public override string Description()
        {
            return "Pigs are pink or brown animals with flat noses and curly tails. They love to roll in mud!";
        }
    }

    public class Chicken : FarmAnimal
    {
        public Chicken()
        {
            Name = "Chicken 🐔";
            SoundFilePath = "~/Content/Animal sounds/Farm Animals/Chicken.mp3";
            ImageFilePath = "~/Content/Images/Animals/Farm/Chicken.png";
        }

        public override string Introduction()
        {
            return "Cluck cluck! I'm Chicky, and I lay eggs every day. Do you want to see my nest?";
        }

        public override string Description()
        {
            return "Chickens are small birds with feathers that can be white, brown, or black. They lay eggs!";
        }
    }

    public class Sheep : FarmAnimal
    {
        public Sheep()
        {
            Name = "Sheep 🐑";
            SoundFilePath = "~/Content/Animal sounds/Farm Animals/Sheeps.mp3";
            ImageFilePath = "~/Content/Images/Animals/Farm/Sheep.png";
        }

        public override string Introduction()
        {
            return "Baa! I'm Woolly Sheep. My fluffy coat keeps me warm and gives you cozy sweaters!";
        }

        public override string Description()
        {
            return "Sheep have fluffy white or gray wool and say 'baa.' Their wool is used to make clothes.";
        }
    }
}
