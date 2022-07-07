using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL03.Models
{
    class Rectangle : Figure
    {
        public double A { get; }
        public double B { get; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double CalculateArea() => A * B;

        public override double CalculatePerimeter() => 2 * (A + B);

        public new virtual string ToString()
        {
            return $"Rectangle: {CalculatePerimeter()}, {CalculateArea()}";
        }
    }
}
