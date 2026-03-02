using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Convert to Octal from Decimal------");
            int dec = 100;
            string octal = Convert.ToString(dec, 8);
            Console.WriteLine("Ocatl value of 100 is : " + octal);

            Console.WriteLine("\n-----Convert to Decimal from Octal------");
            Console.WriteLine("Decimal value of 144 is : " + Convert.ToInt32(octal, 8));

            Console.ReadKey();
        }
    }
}
