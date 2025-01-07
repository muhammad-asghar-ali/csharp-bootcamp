using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphsim
{
    abstract class Shape
    {
        public string Name { get; set; }

        // Can define non-abstract methods in an abstract class
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        // Want subclasses to override this method so mark it as abstract
        // Can only make abstract methods in abstract classes
        public abstract double Area();
    }
}