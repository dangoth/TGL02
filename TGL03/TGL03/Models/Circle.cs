using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL03.Models
{
    public class Circle : Figure

    {
        public double Radius { get; }

        public Circle (double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public new string ToString()
        {
            return $"Circle area: {CalculateArea()}, circle perimeter: {CalculatePerimeter()}";
        }
    }
}
