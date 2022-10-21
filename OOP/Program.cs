using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathematicsOperations mathOp = new MathematicsOperations();

            int result = mathOp.Add(4, 5, new int[] {2, 3, 4, 6, 11});

            Console.WriteLine(result);

        }
    }
}
