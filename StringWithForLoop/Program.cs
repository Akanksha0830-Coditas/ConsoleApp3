using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWithForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "akankshakumbhar3008@gmail.com";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;

            Console.WriteLine("---Using for loop-");
            for (int i = 0; i < email.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (email[i] == vowels[j])
                        vowelsCount++;
                }               
            }
            Console.WriteLine("Total vowels: " + vowelsCount);

            Console.WriteLine("\n---Using arrays and collection---");
            vowelsCount = 0;
            for (int i = 0; i < email.Length; i++)
            {
                if (Array.IndexOf(vowels, email[i]) >= 0)
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine("Total vowels: " + vowelsCount);


            Console.WriteLine("\n---Using LINQ---");
            Console.WriteLine("Total vowels: " + email.Count(ch => Array.IndexOf(vowels,ch) >= 0));
        }
    }
}
