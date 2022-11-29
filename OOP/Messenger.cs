using System;

namespace OOP
{
    public class Messenger
    {
        public void Inform(string studentName, int time, decimal interest)
        {
            Console.WriteLine($"A new student {studentName} has been successfully onboarded. Interest to pay after {time} years is {interest}.");
        }
    }
}
