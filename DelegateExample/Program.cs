using DelegatesExample;
using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using static DelegatesExample.Price;

namespace DelegatesExample
{
    public class Price
    {
        // Creating a method
        public double CalculatePrice(int cost, int gst)
        {
            double totalCost = cost + gst;
            return totalCost;
        }

        // Creating a delegate

        public delegate double CalculatePriceDelegate( int cost, int gst );

    }

    //------------------------Multi Cast Delegates--------------------------




    // create delegate
    public class FinalPrice
    {
        // 1. Declare the delegate to match the signature: returns double, takes two ints
        public delegate double FinalPriceDelegate(int val1, int val2);

        public double Discount(int cost, int addon)
        {
            double discountPercent = addon;
            double discountedPrice = cost - (cost * discountPercent / 100.0);
            Console.WriteLine($"The discounted price is : {discountedPrice}");
            return discountedPrice;
        }

        public double Gst(int cost, int addon)
        {
            double gstRate = addon;
            double addedGst = cost + (cost * gstRate / 100.0);
            Console.WriteLine($"The price with GST is {addedGst}");
            return addedGst;
        }



        public class Program
        {
            static void Main(string[] args)
            {
                // Create object of Price Class
                Price p = new Price();

                // Create object of delegate
                CalculatePriceDelegate mydelegate = new CalculatePriceDelegate(p.CalculatePrice);

                //Invoke method using delegate object
                Console.WriteLine(mydelegate.Invoke(1000, 8));

                Console.ReadKey();

                Console.Clear();

                Console.WriteLine(" --------------Multi Csting Example----------");

                FinalPrice fp = new FinalPrice();

                // 2. Instantiate the delegate and point it to the Discount method
                FinalPriceDelegate del = fp.Discount;

                // 3. Invoke the method through the delegate
                double result = del(1000, 10);

                // You can also point the same delegate to the Gst method
                del = fp.Gst;
                del(1000, 18);

            }
        }
    }
}
