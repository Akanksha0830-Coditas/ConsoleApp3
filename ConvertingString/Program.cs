using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "My name is Akanksha. I love to play Badminton";

            Console.WriteLine("String is : " + x);
            Console.WriteLine("Length of current string id : " + x.Length);
            // string str = x.ToUpper();
            // Console.WriteLine(str); --> if u want to store the upper case string in an another string

            Console.WriteLine("ToUpper : " + x.ToUpper());// converts entire string

            Console.WriteLine();
            // If u want to convert only one character from the string then , string -> array
            char[] arr = x.ToCharArray();
            Console.WriteLine("Convertig only 1 letter to upper : " + char.ToUpper(arr[1]));
            // prints only one converted letter
            arr[1] = char.ToUpper(arr[1]);
            string result = new string(arr); // again convert to string to print the entire string
            Console.WriteLine(result);

            /*string x = "My name is Akanksha";
        
            string y = x.ToLower();
        
            Console.WriteLine(x);
            Console.WriteLine(y);
        
            string z = y.Replace("my", "My").Replace("akanksha", "Akanksha");
        
            Console.WriteLine(z);

            Output:
            My name is Akanksha
            my name is akanksha
            My name is Akanksha

            */

            Console.WriteLine();

            Console.WriteLine("Tolower : " + x.ToLower());
            Console.WriteLine("Substring with start index : " + x.Substring(8));
            Console.WriteLine("Substring with start index and no. of chars : " + x.Substring(9, 10));
            Console.WriteLine("Replace Akanksha with Akii : " + x.Replace("Akanksha", "Akii"));
            Console.WriteLine("Replace space with and : " + x.Replace(". ", " and "));

            Console.WriteLine() ;
            Console.WriteLine("---Splitting the string---");

            string[] wordsinstring = x.Split(' ');
            //foreach loop as it is a array
            foreach(var item in wordsinstring)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            // Convert string to array
            Console.WriteLine("----ToCharArray--");

            string str = "Akanksha";

            char[] ch = str.ToCharArray();
            foreach(var item in ch)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("\n---Array to string");
            // Convert array to string
            char[] c = { 'h', 'e', 'l', 'l', 'o' };
            string str2 = new string(c);
            Console.WriteLine(c);

            Console.WriteLine("\n---Join the array");

            string[] nickname = { "I", "am", "Gubbu", "Kumbhar" };
            string awwname = string.Join("-", nickname);
            Console.WriteLine(awwname);
        }
    }
}
