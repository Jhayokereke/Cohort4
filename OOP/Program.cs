using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerator = 1800;
            int divisor = 100;
            int quotient = numerator / divisor;
            int remainder = numerator % divisor;
            Console.WriteLine($"{numerator} divided by {divisor} gives us {quotient} remainder {remainder}");
            
            //1234 + 99 = 1333 / 100 = 13;
            //1800 + 99 = 1899 / 100 = 18;
            //3467 + 99 = 3566 / 100 = 35;
            int[] years = new int[] { 1234, 1800, 3467, 235, 1888, 1960, 2020, 2021, 2037, 1405, 1914, 1287 };
            for (int i = 0; i < years.Length; i++)
            {
                Console.WriteLine();
                int year = years[i];
                int century = Kata.СenturyFromYear(year);
                Console.WriteLine($"The year {year} falls into the {century} century.");
            }
        }
    }
}
