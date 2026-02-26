using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String x = "Akanksha Kumbhar";
            String y = "Akanksha";
            String z = x; // address of object in x is assigned to z

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            x = "Akii";

            Console.WriteLine("\nAfter changing the value of x : " + x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("\n" + x.Length);
            Console.WriteLine(x[1]); // char string [int index]
        }
    }
}
