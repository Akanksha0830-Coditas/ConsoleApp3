using System;
using System.IO;

namespace FileInfoPropertiesExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\Coditas-Admin\source\Akanksha\FileInfo\Japan.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            //ileInfo.Create().Close();
            Console.WriteLine("Exists: " + fileInfo.Exists);
            if (fileInfo.Exists)
            {
                File.AppendAllText(filePath, "Akanksha Kumbhar");
                Console.WriteLine("FullName: " + fileInfo.FullName);
                //string s = fileInfo.FullName;
                Console.WriteLine("Name: " + fileInfo.Name);
                Console.WriteLine("DirectoryName: " + fileInfo.DirectoryName);
                Console.WriteLine("Extension: " + fileInfo.Extension);
                Console.WriteLine("Length: " + fileInfo.Length + " bytes");
                Console.WriteLine("LastWriteTime: " + fileInfo.LastWriteTime);
                Console.WriteLine("LastAccessTime: " + fileInfo.LastAccessTime);
                Console.WriteLine("CreationTime: " + fileInfo.CreationTime);
            }
            else
            {
                Console.WriteLine("File not found");
            }
            Console.ReadKey();
            Console.Clear();

            //fileInfo.Delete();
            Console.WriteLine("Deleting the file . . .");
        }
    }
}
