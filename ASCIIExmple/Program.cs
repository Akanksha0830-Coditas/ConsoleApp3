using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIExmple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            byte b = (byte)ch;
            //int b = (int)ch;
            Console.WriteLine(b); //65

            //reconverting again
            char ch1 = (char)b;
            Console.WriteLine(ch1); // A

            //generate byte[]
            byte[] bytes = new byte[128];
            for (byte i = 0; i < 128; i++)
            {
                bytes[i] = i;
            }
            string s = System.Text.Encoding.ASCII.GetString(bytes); //byte[] to string
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            // outputencoding  => property of console
            Console.WriteLine(s);
            Convert.ToBase64String(bytes);

        }
    }
}
