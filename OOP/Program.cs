using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>();
            set.Add(5);
            set.Add(2);
            set.Add(3);
            set.Add(6);
            set.Add(1);
            set.Add(4);
            set.Add(5);

            Console.WriteLine(set.Count);

            Console.WriteLine("[" + string.Join(", ", set) + "]");

            var newSet = set.Where(GreaterThan);
            Console.WriteLine(newSet.Count());
        }

        static bool GreaterThan(int x)
        {
            return x > 5;
        }
    }
}
//1, 2, 3,4 ,5 ,6 ,7
//Arrays => type safe, do not change size
//arraylist => not type safe, change size
//Lists => type safe, change size
//hashtable => k:v
//dictionaries => 
//hashsets => 
//sortedsets =>