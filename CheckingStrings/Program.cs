using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Akanksha";
            string name1 = "Omkar";
            string name2 = "akanksha";
            string name3 = " ";
            string name4 = "";
            string name5 = null;
            string name6 = null;

            Console.WriteLine("name is : " + name);
            Console.WriteLine("name1 is : " + name1);
            Console.WriteLine("name2 is : " + name2);

            Console.WriteLine("\n---------Equals-------");

            Console.WriteLine("\nIs Akanksha equals to Omkar : " + name.Equals(name1)); // bool value -> false
            Console.WriteLine("Is Akanksha equals to Akanksha : " + name.Equals(name2)); //false
            Console.WriteLine(string.Equals(name5, name6));
            Console.WriteLine(name5.Equals(name6)); // give exception ( cant call a method on null)

            Console.WriteLine("\n---------Starts With and Ends With-------");

            Console.WriteLine("\nDoes Akanksha starts with Ak : " + name.StartsWith("Ak"));
            Console.WriteLine("Does Akanksha starts with a : " + name.StartsWith("a"));
            Console.WriteLine("Does Akanksha ends with ha: " + name.EndsWith("ha"));
            Console.WriteLine("Does Akanksha ends with ah: " + name.EndsWith("ah"));

            Console.WriteLine("\n---------Contains-------");

            Console.WriteLine("\nDoes Omkar contains e: " + name1.Contains("e"));
            Console.WriteLine("Does Omkar contains ar: " + name1.Contains("ar"));

            Console.WriteLine("\n---------IndexOf-------");

            Console.WriteLine("\nIndex of A in Omkar is : " + name1.IndexOf("A"));
            Console.WriteLine("Index of a in Omkar is : " + name1.IndexOf("a"));
            Console.WriteLine("Index of ka in Omkar is : " + name1.IndexOf("ka"));

            Console.WriteLine("\nIndex of a in akanksha is : " + name2.IndexOf("a"));
            Console.WriteLine("Index of 2nd a from index 1 in akanksha is : " + name2.IndexOf("a", 1));

            Console.WriteLine("\n---------LastIndexOf-------");

            Console.WriteLine("\nLastIndex of a in akanksha is : " + name2.LastIndexOf("a"));
            Console.WriteLine("LastIndex of 2nd a from index 1 in akanksha is : " + name2.LastIndexOf("a", 1));
            Console.WriteLine("LastIndex of nk from index 5 in akanksha is : " + name2.LastIndexOf("nk", 5));

            Console.WriteLine("\n---------IsNullOrEmpty-------");

            Console.WriteLine("\nIs the string akanksha empty : " + string.IsNullOrEmpty(name2));
            Console.WriteLine("Is the string \" \" empty : " + string.IsNullOrEmpty(name3));
            Console.WriteLine("Is the string \"\" name empty : " + string.IsNullOrEmpty(name4));
            Console.WriteLine("Is the string null empty : " + string.IsNullOrEmpty(name5));

            Console.WriteLine("\n---------IsNullOrWhiteSpace-------");

            Console.WriteLine("Is the string \" \" with whiteSpace empty : " + string.IsNullOrWhiteSpace(name3));

            Console.ReadKey();
        }
    }
}
