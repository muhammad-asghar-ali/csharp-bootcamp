using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics
{
    public class Animal
    {
        // Attributes (fields) that all Animals have public means can be directly changed after an object has been created
        private string name;
        private string sound;

        // static fields and methods belong to the class. A static field has the same value for all objects of the Animal type
        public static int numOfAnimals = 0;

        // Can define constants
        public const string SHELTER = "John's Home for Animals";

        // Can define read-only fields that are set at runtime in constructors, but then can't be changed
        public readonly int idNum;

        // A constructor sets default values for fields when an object is created.
        // This is the default constructor if no parameters are sent.
        public Animal() : this("No Name", "No Sound") { }

        // Can create additonal constructors but since we are definig defaults you don't have to
        // Constructor called if only name is passed this passes the parameters to the next constructor
        public Animal(string name)
            : this(name, "No Sound") { }

        // Constructor that receives parameters
        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            // Increment the number of animals
            NumOfAnimals = 1;

            // Define the read-only value which is the same for all Animals
            Random rnd = new();
            idNum = rnd.Next(1, 2147483640);
        }

        // Capabilities (methods) that all Animals have
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

        // Setters (Mutators) protect the fields from receiving bad data
        public void SetName(string name)
        {
            // Any checks if any character in the string is a number and if so returns true
            // Since we won't allow numbers we will protect our data
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }

        // Getters (Accessors) can provide output aside from the value stored
        public string GetName()
        {
            return name;
        }

        // The preferred way to define getters and setters is through properties
        public string Sound
        {
            get { return sound; }
            set
            {
                // value is assigned the value passed in
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }

        // You can have the getters and setters generated for you like this and also set the default value
        public string Owner { get; set; } = "No Owner";

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }
    }
}