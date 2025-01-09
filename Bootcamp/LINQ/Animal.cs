using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ
{
    public class Animal(string name = "No Name",
        double weight = 0,
        double height = 0)
    {
        public string Name { get; set; } = name;
        public double Weight { get; set; } = weight;
        public double Height { get; set; } = height;
        public int AnimalID { get; set; }

        public override string ToString()
        {
            return string.Format("{0} weighs {1}lbs and is {2} inches tall",
                Name, Weight, Height);
        }
    }
}