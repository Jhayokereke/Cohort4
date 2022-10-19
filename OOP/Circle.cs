using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; set; }
        public int Diameter
        {
            get
            {
                return Radius * 2;
            }
        }
        public double Circumference 
        { 
            get 
            {
                return Math.PI * Diameter;
            }
        }
        public double Area 
        { 
            get
            {
                int rad = Radius;
                return Math.PI * rad * rad;
            }
        }
    }
}
