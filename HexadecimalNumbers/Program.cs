using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Convert to Hexadecimal from Decimal------");
            int dec = 742;
            string hexa = Convert.ToString(dec, 16);
            Console.WriteLine("Binary value of 742 is : " + hexa);

            Console.WriteLine("\n-----Convert to Decimal from Hexadecimal------");
            Console.WriteLine("Decimal value of 2e6 is : " + Convert.ToInt32(hexa, 16));

            Console.ReadKey();
        }
    }
}
