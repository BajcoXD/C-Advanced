using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double CalculateArea()
        {
            // Heron's formula
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
