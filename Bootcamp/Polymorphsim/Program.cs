using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach (Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}",
                s.Name, s.Area());

                // Can use as to check if an object is of a specific type
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                // can use is to check the data type
                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }


                Console.WriteLine();
            }

            // Can store any class as a base class and call the subclass methods
            // even if they don't exist in the base class by casting
            object circ1 = new Circle(4);

            Circle circ2 = (Circle)circ1;
            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());


            Console.ReadLine();
        }
    }
}