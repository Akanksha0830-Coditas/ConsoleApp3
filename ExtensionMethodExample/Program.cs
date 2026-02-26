using System;
using System.Security.Authentication.ExtendedProtection;

namespace ExtensionMethodExample
{

    // Extension class using static 
    public static class CostCalculation
    {
        //extended method using static and main class name and parameter
        public static double TotalCostOfTests(this LabManagementSys lab)
        {
            lab.noOfTests = 3;
            lab.testPrice = 300;

            return lab.noOfTests * lab.testPrice;
        }


    }
    public class LabManagementSys
    {
        public int noOfTests { get; set; }
        public double testPrice { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //LabManagementSys lms = new LabManagementSys();
            var lms = new LabManagementSys(); // use of var keyword to shorten the name 

            Console.WriteLine(lms.TotalCostOfTests());
        }
    }
}
