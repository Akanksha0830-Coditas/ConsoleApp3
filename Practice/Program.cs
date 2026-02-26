using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? RollNo = null;

        //    if (name == null)
        //    {
        //        Console.WriteLine("Name doesnt exist");
        //    }
        //    else
        //    {
        //        Console.WriteLine(name.Length); // Unhandled exception 

        //    }

        //    Console.WriteLine(name); // get no output 

            Console.WriteLine(RollNo.HasValue);
            Console.WriteLine(RollNo ?? 0);
        }
    }
}
