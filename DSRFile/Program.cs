using System;
using System.IO;
using System.Text;

namespace DSRFile
{
    class Program
    {
        static void Main()
        {
            string sourcePath = @"C:\Users\Coditas-Admin\source\Akanksha\MonthlyDSR.txt";
            string destinationPath = @"C:\Users\Coditas-Admin\source\Akanksha\SelectedDSR.txt";

            Console.Write("Enter date (dd MMM yyyy): ");
            string inputDate = Console.ReadLine();

            string[] lines = File.ReadAllLines(sourcePath);

            StringBuilder selectedDSR = new StringBuilder();
            bool isSelected_DSRBlock = false;

            foreach (string line in lines)
            {
                // Start copying when selected date is found
                if (line.StartsWith(inputDate))
                {
                    isSelected_DSRBlock = true;
                }
                // Stop when next date block starts
                else if (isSelected_DSRBlock && line.Length > 0 && Char.IsDigit(line[0]))
                {
                    break;
                }

                // Add lines while copying
                if (isSelected_DSRBlock)
                {
                    selectedDSR.AppendLine(line);
                }
            }

            if (selectedDSR.Length > 0)
            {
                File.WriteAllText(destinationPath, selectedDSR.ToString());
                Console.WriteLine("Selected DSR copied successfully!");
            }
            else
            {
                Console.WriteLine("Date not found in DSR file.");
            }
        }
    }
}