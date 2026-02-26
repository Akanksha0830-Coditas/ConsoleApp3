using System;

namespace NullHandlingExample
{
    public class Coditas
    {
        public double? evalScore;
        public string internName;

        static void Main(string[] args)
        {
            Coditas c1 = new Coditas();
            c1.evalScore = 4.67;
            c1.internName = "Akanksha";

            Coditas c2 = new Coditas();
            c2.evalScore = null;
            c2.internName = "Omkar";

            Console.WriteLine(c1.evalScore.HasValue); // output true 
            Console.WriteLine(c2.evalScore.HasValue);

            Console.WriteLine();

            // using Null Coalesing opertaor (??)
            Console.WriteLine(c1.evalScore ?? 0); // output 4.67 
            Console.WriteLine(c2.evalScore ?? 0); // output 0

            Console.WriteLine();

            // Lengthy code for Null propagation operator

            //Console.WriteLine((c1.internName == null) ? null : c1.internName);
            //Console.WriteLine((c2.internName == null) ? null : c2.internName);

            // short code for null prop op

            Console.WriteLine(c1?.internName);
            Console.WriteLine(c2?.evalScore); // output __ 
            Console.WriteLine(c2?.internName);            

        }   

    }      
}
