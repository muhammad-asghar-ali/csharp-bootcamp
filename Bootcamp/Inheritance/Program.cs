using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrrr"
            };

            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();

            // Define the AnimalIDInfo
            whiskers.SetAnimalIDInfo(12345, "Sally Smith");
            grover.SetAnimalIDInfo(12346, "Paul Brown");

            whiskers.GetAnimalIDInfo();

            // Test the inner class
            Animal.AnimalHealth getHealth = new();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

            // Can define 2 Animal objects but have
            // one actually be a Dog type. 
            Animal monkey = new()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooff",
                Sound2 = "Geerrrr"
            };

            // The problem is that if call a function in Animal it won't call
            // the overridden method in Dog unless the method that might be overridden is marked virtual
            spot.MakeSound();

            // This is an example of how Polymorphism allows a subclass to override a method
            // in the super class and even if the subclass is defined as the super class
            // type the correct method will be called
            Console.ReadLine();
        }
    }
}