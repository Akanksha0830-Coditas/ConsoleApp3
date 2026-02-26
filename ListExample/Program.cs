using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create a reference variable for List Class and create object of List Class
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50 };

            // For accessing the elements from the list
            Console.WriteLine("By using ForEach loop");

            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nBy using For loop");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }
    }
}
