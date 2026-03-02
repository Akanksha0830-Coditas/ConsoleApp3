using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Coditas-Admin\source\Akanksha\FileInfo\Student.txt";
            string destPath = @"C:\Users\Coditas-Admin\source\Akanksha\FileInfo\MITAOE.txt";
            string destPath2 = @"C:\Users\Coditas-Admin\source\Akanksha\FileInfo\University.txt";
            // Create a object of FileInfo class having source path
            FileInfo FI = new  FileInfo(sourcePath);

            // Create()
            FI.Create().Close();
            Console.WriteLine("Student file is being creating !! . . . . ");

            // CopyTo()
            //FI.CopyTo(destPath);
            FileInfo FI2 = FI.CopyTo(destPath, true);
            Console.WriteLine($"Student is copied to {FI2.Name} . . . ");

            //MoveTo
            FI2.MoveTo(destPath2);
            Console.WriteLine($"MITAOE is moved to University . . . ");

            Console.ReadKey();
            Console.Clear();

            FI.Delete();
            Console.WriteLine("Deleting Student . . . .");
            FI2.Delete();
            Console.WriteLine("Deleting MITAOE after moving to University . . . .");
        }
    }
}
