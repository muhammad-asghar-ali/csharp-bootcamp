using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Generic collections are type safe and provide performance benefits

            List<Animal> animalList = new List<Animal>();
            List<int> numList = new List<int>();

            // Add an int
            numList.Add(24);

            // Add Animals
            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            animalList.Insert(1, new Animal() { Name = "Steve" });
            animalList.RemoveAt(1);

            Console.WriteLine("Num of Animals : {0}", animalList.Count());

            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);

            }

            // Can also use Stack<T>, Queue<T>,
            // Dictionary<TKey, TValue> like I covered
            // previously

            // Generic methods
            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            // It works for strings as well
            string strX = "5", strY = "4";
            Animal.GetSum(ref strX, ref strY);

            // Use the generic struct
            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("20", "50");
            Console.WriteLine(rec2.GetArea());

            // Delegates allow you to reference methods inside a delegate object. The delegate
            // object can then be passed to other methods that can call the methods assigned
            // to the delegate. It can also stack methods that are called in the specified order

            // Create delegate objects
            Arithmetic add, sub, addSub;

            // Assign just the Add method
            add = new Arithmetic(Add);

            // Assign just the Subtract method
            sub = new Arithmetic(Subtract);

            addSub = add + sub;
            sub = addSub - add;

            Console.WriteLine($"Add {6} & {10}");
            add(6, 10);

            Console.WriteLine($"Sub {6} & {10}");
            sub(6, 10);

            Console.WriteLine($"Add & Subtract {10} & {4}");
            addSub(10, 4);

            Console.ReadLine();
        }

        // You can also create generic structs
        // and classes in this same way
        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);

                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
            }
        }

        // Declare a delegate type that performs arithmetic. It defines the return type and the types for attributes
        public delegate void Arithmetic(double num1, double num2);

        // Methods that will be assigned to the delegate

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
    }
}