using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // for string builder


namespace StringBuilder1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Normal Method-----------------------------");
            string[] intro = { "My", "name", "is", "Akanksha", "and", "I", "love", "to", "play", "badminton" };
            string sentence = "";// to get op as full sentence
            // My name is Akanksha and I love to play badminton
            foreach (string word in intro)
            {
                sentence = sentence + " " + word; // Problem : a new object is created 8 times
            }
            Console.WriteLine(sentence);


            Console.WriteLine("\n----------------With String Builder-------------------------");
            StringBuilder sb = new StringBuilder();
            foreach (string word in intro)
            {
                sb.Append(word + " " );
                Console.WriteLine(sb.ToString() + "," + sb.Capacity);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
