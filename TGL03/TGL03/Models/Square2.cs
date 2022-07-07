using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL03.Models
{
    class Square2 : Figure
    {
        public double A { get; }

        public Square2(double a)
        {
            A = a;
        }
        public override double CalculateArea() => Math.Pow(A, 2);

        public override double CalculatePerimeter() => 4 * A;
    }
}
