using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    // When inherit from another class you receive all of its fields and methods
    // Cannot inherit from multiple classes
    class Dog : Animal
    {
        // Can add additional properties
        public string Sound2 { get; set; } = "Grrrrr";

        // Can overwrite methods by adding new
        /*
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        */

        // Add override so that the correct method is called when a Dog is created as an Animal type
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        // Create a constructor that has the base sonstructor initialize everything except Sound2
        public Dog(string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound 2")
            : base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}