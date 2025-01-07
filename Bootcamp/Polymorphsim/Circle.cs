using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphsim
{
    class Circle : Shape
    {
        public double Radius { set; get; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        // Can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            Console.WriteLine($"It has a Radius of {Radius}");
        }
    }
}