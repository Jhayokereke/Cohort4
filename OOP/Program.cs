using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(7);

            Console.WriteLine($"The circle with radius {circle.Radius} has a Diameter of {circle.Diameter}, a circumference of {circle.Circumference} and area of {circle.Area}.");

            Console.WriteLine("Changing radius value....");
            Console.Write("Radius: ");
            string newRadius = Console.ReadLine();
            Console.WriteLine("New radius value is {0}", newRadius);
            circle.Radius = int.Parse(newRadius);

            Console.WriteLine($"The circle with radius {circle.Radius} has a Diameter of {circle.Diameter}, a circumference of {circle.Circumference} and area of {circle.Area}.");
            Console.WriteLine("Goodbye!");
        }
    }
}
