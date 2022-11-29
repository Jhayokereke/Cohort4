using System.Linq;
using System;

namespace OOP
{
    public static class Kata
    {
        public static int СenturyFromYear(int year)
        {
            if (year % 100 > 0)
            {
                return (year / 100) + 1;
            }
            else
            {
                return year / 100;
            }

            //return (year + 99) / 100;

            //return year % 100 > 0 ? (year / 100) + 1 : year / 100;
        }

        public static int MathMethod(string operation, int[] values)
        {
            switch (operation)
            {
                case "add":
                    return values.Sum();
                case "multiply":
                    //
                    return 0;
            }
            return 0;
        }

        public static decimal SimpleInterestCalculator(decimal principal, double rate, int time)
        {
            return 0;
        }
        public static decimal CompoundInterestCalculator(decimal principal, double rate, int time)
        {
            return 4;
        }

        public static string ToNairaCurrency(this decimal amount)
        {
            return string.Format(new System.Globalization.CultureInfo("en-NG"), "{0:c2}", amount);
        }

        public static void Print<T>(this T message)
        {
            Console.WriteLine(message);
        }
    }
}
