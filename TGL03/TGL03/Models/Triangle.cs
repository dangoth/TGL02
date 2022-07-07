using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL03.Models
{
    class Triangle : Figure
    {
        double A { get; }
        double B { get; }
        double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a; B = b; C = c; 
        }
        public override double CalculateArea()
        {
            var s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override double CalculatePerimeter() => A + B + C;

        public override string ToString()
        {
            return $"Area: {CalculateArea()}, Perimeter: {CalculatePerimeter()}";
        }
    }
}
