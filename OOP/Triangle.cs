using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Triangle
    {
        public Triangle(int h, int b)
        {
            Height = h;
            Base = b;
            Area = 0.5 * b * h;
        }

        public int Height { get; set; }
        public int Base { get; set; }
        public double Perimeter { get; }
        public double Area { get; }
    }
}
