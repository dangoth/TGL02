using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGL03.Models
{ 
    public abstract class Figure
    {
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return $"Perimeter: {CalculatePerimeter()}, Area: {CalculateArea()}";
        }
    }
}
