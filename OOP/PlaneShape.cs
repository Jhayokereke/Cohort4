using System;

namespace OOP
{
    public class PlaneShape
    {
        public PlaneShape(int height, int width)
        {
            Height = height;
            Width = width;
            Area = Height * Width;
        }
        private int _height;
        public int Height 
        {
            get
            {
                return _height;
            }
            set 
            {
                if (value % 10 != 0)
                {
                    throw new Exception("Value is not divisible by 10");
                }
                _height = value / 10;
            }
        }
        public int Width { get; set; } = 300;
        public double Area { get; }
    }
}
