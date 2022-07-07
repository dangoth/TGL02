using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGL03.Models;

namespace TGL03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>
            {
                new Circle(5),
                new Rectangle(5, 10),
                new Square1(4),
                new Square2(4),
                new Triangle(2, 4, 5)
            };

            foreach (var f in figures)
            {
                Console.WriteLine(f);
            }
        }
    }
}
