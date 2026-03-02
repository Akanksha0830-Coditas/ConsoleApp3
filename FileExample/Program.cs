using System;
using System.Collections.Generic;
using System.IO;

namespace FileExample
{
    /// <summary>
    /// File operations
    /// 
    /// File.Create(string path) => create a file 
    /// .Close() => to close the file in memory
    /// .Copy(source path, destination path) => copy the existing file in same folder or in diff folder with data
    /// .Move(source path, destination path) => Rename the file and Move the file to the mentioned destination
    ///                                         The original file is just replaced or moved 
    /// .Delete(file name) => deletes the file 
    /// 
    /// .WriteAllText(file path, content) => writes the text in file , if text already there it overrites it 
    /// .ReadAllText(file path) => Read the text from file --> for single line string  
    /// 
    /// .WriteAllLines(file path, list or array name) => adds the data in file
    /// .ReadAllLine () --> for List<string> or string[]
    /// 
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verbatim string
            //string intro = @"
            //   My name is Akanksha
            //   ""Hello""
            //";
            //Console.WriteLine(intro);


            // File.Create("C:\\Users\\Coditas-Admin\\source\\Akanksha\\FilePractice\\FirstFile.txt");

            //File.Create(@"C:\Users\Coditas-Admin\source\Akanksha\FilePractice\FirstFile.txt");
            // @ -> disable the escape sequence character

            // .Close() => to close the file in memory

            string file1 = @"C:\Users\Coditas-Admin\source\Akanksha\FilePractice\File1.txt";
            string file2 = "C:\\Users\\Coditas-Admin\\source\\Akanksha\\FilePractice\\File2.txt";
            string file3 = "C:\\Users\\Coditas-Admin\\source\\Akanksha\\FilePractice1\\File3.txt";
            string content = "My name is Akanksha , I'm a .Net developer";

            File.Create(file1).Close();
            Console.WriteLine("File1 created!!");

            bool exists = File.Exists(file1);

            if (exists)
            {
                Console.WriteLine("Checking if file1 exists . . . . Yes! File1 Exists!");

                File.WriteAllText(file1, content);
                Console.WriteLine("\nContent added in file1");

                string s = File.ReadAllText(file1);
                Console.WriteLine("\nContent added in the file1 was.... :\n " + s);

                File.Copy(file1, file2);
                Console.WriteLine("\nFile1 coping to file2 . . .  . . . ");

                // For this the file2 should not exist first
                File.Move(file2, file3);
                Console.WriteLine("\nfile2 renamed as file3 and moved to different location . . . ");

                Console.WriteLine("\nReading all the text from originally file1 as in file3. . . . . ");
                Console.WriteLine(File.ReadAllText(file3));                
            }
            else
            {
                Console.WriteLine("\nChecking if file1 exists . . . .File1 not found!");
            }
            
            string FileMyntra = @"C:\Users\Coditas-Admin\source\Akanksha\FilePractice\Myntra.txt";
            //Collections
            List<string> Myntra = new List<string>()
            {
                "BodyConDress", "Frock", "Makeup", "Jewels", "Heels"
            };

            File.WriteAllLines(FileMyntra, Myntra);
            Console.WriteLine("\nContent Added to Myntra File!!");

            string[] myn = File.ReadAllLines(FileMyntra);
            foreach(var line in myn)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
            Console.Clear();

            File.Delete(file1);
            Console.WriteLine("File1 Deleted!!");
            File.Delete(file3);
            Console.WriteLine("Fil31 Deleted!!");
            File.Delete(FileMyntra);
            Console.WriteLine("FileMyntra Deleted!!");
        }
    }
}
