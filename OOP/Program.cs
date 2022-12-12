using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing main thread...");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Thread childThread = new Thread(CreateNewUser);
            childThread.Start(name);

            Console.WriteLine("Welcome {{{0}}}", name);
        }

        static void CreateNewUser(object username)
        {
            string name = (string)username;
            Thread.Sleep(3000);
            Console.WriteLine("New user created {{{0}}}", name);
        }

        static void LongRunningTask(object thread)
        {
            string name = (string)thread;
            for (int i = 5; i > -1; i--)
            {
                Console.WriteLine("Running on {0}: {1}", name, i);
                Thread.Sleep(1000);
            }
        }

        static void AnotherLongRunningTask()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Running on thread 2: "+i);
                Thread.Sleep(100);
            }
        }
    }
}