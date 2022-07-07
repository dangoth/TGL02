using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL03.Models
{
    class Square1 : Rectangle
    {
        public Square1(double a) : base(a, a)
        {
        }

        public override string ToString()
        {
            return $"Square: {CalculatePerimeter()}, {CalculateArea()}";
        }
    }
}
