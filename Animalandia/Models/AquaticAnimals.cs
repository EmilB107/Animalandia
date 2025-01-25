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
            ImageFilePath = "~/Content/Images/Animals/Aquatic/Dolphin.png";
        }

        public override string Introduction()
        {
            return "Eee! I'm Dolly Dolphin, and I love jumping high and playing in the ocean waves!";
        }

        public override string Description()
        {
            return "Dolphins are playful and intelligent marine animals that live in oceans. They have smooth, gray skin and a curved dorsal fin on their backs. " +
                "Dolphins are fast swimmers and often leap out of the water. They eat fish and squid and use a special clicking sound called echolocation to find their food. " +
                "Dolphins are social animals and live in groups called pods.";
        }
    }

    public class Shark : AquaticAnimal
    {
        public Shark()
        {
            Name = "Shark 🦈";
            SoundFilePath = "~/Content/Animal sounds/Aquatic/Shark (2).mp3";
            ImageFilePath = "~/Content/Images/Animals/Aquatic/Shark.png";
        }

        public override string Introduction()
        {
            return "Hey there! I'm Sharky Shark. Don't worry, I'm just a big fish with a toothy grin!";
        }

        public override string Description()
        {
            return "Sharks are large, strong fish with sharp teeth and a sleek body built for swimming fast. They can be gray, blue, or even white, depending on the species. " +
                "Sharks are excellent hunters and have a great sense of smell to find their prey. Despite their fearsome reputation, most sharks are not dangerous to humans. " +
                "They play an important role in the ocean’s ecosystem.";
        }
    }

    public class Octopus : AquaticAnimal
    {
        public Octopus()
        {
            Name = "Octopus 🐙";
            SoundFilePath = "~/Content/Animal sounds/Aquatic/Shark (2).mp3";
            ImageFilePath = "~/Content/Images/Animals/Aquatic/" +
                "Octopus.png";
        }

        public override string Introduction()
        {
            return "Hi! I'm Ollie Octopus, and I have eight arms for hugs and playing hide-and-seek!";
        }

        public override string Description()
        {
            return "Octopuses are fascinating sea creatures with soft, round bodies and eight long arms covered in suckers. " +
                "They can change their skin color and texture to blend in with their surroundings. Octopuses are very smart and can solve puzzles to find food. " +
                "They live in oceans and eat crabs, shrimp, and fish. When threatened, they can squirt ink to escape from predators.";
        }
    }
}
