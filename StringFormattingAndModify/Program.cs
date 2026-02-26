using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormattingAndModify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------String Formatting--------");
            string name = "Akanksha", rollNo = "202201040112";
            Console.WriteLine($"\nMy name is {name}.My roll no is {rollNo}");

            Console.WriteLine("\n---------String Modify (Insert)------");

            string str1 = "CheckString";
            Console.WriteLine(str1);
            Console.WriteLine("\nAfter inserting ing to the string : " + str1.Insert(5, "ing"));

            Console.WriteLine("\n---------String Modify (Remove)------");

            string str2 = "CheckingString";
            Console.WriteLine(str2);
            Console.WriteLine("\nAfter inserting ing to the string : " + str2.Remove(5, 3));
        }
    }
}
