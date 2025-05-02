using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Exercise.Entities.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public Fish(string name, int age, string color, string size)
            : base(name, "Fish", age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Fish - Name: {Name}, Age: {Age}, Color: {Color}, Size: {Size}");
        }
    }
}
