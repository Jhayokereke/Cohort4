using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class GenericClass<T> 
    {
        public void Print(T message)
        {
            Console.WriteLine(message);
        }
    }
}
