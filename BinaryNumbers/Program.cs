using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Convert to Binary from Decimal------");
            int dec = 13;
            string binary = Convert.ToString(dec, 2);
            Console.WriteLine("Binary value of 13 is : " + binary);

            Console.WriteLine("\n-----Convert to Decimal from Binary------");
            Console.WriteLine("Decimal value of 1101 is : " + Convert.ToInt32(binary, 2));

            Console.ReadKey();
        }
    }
}
