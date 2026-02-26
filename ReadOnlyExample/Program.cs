using System;

namespace StructuresExample
{
    public readonly struct ReadOnlyExample
    {
        // Fields
        private readonly string _bookName;

        // Properties
        //public string BookName // only getters 
        //{
        //    get
        //    {
        //        return _bookName;
        //    }
        //}

        // method
        //public void GetBookName()
        //{
        //    Console.WriteLine($"The book name from method is {BookName}");
        //}

        //constructor 
        public ReadOnlyExample(string bookName)
        {
            this._bookName = bookName;
            Console.WriteLine(bookName);
        }

        public static void Main(string[] args)
        {
            //Meesho m = new Meesho(); //The new keyword for a struct simply tells the compiler to initialize all fields.
            // As a constructor is created 
            //Meesho m = new Meesho(50, "BodyConDress", 500);

            ////m.ProductID = 50;
            ////m.ProductName = "BodyConDress";
            ////m.ProductPrice = 500;

            //Console.WriteLine(m.GetProductInfo());

            //Console.WriteLine("\n-----------------------------\n");

            // create struct instance
            ReadOnlyExample ro = new ReadOnlyExample("Akanksha");

            //ro.GetBookName();
            //Console.WriteLine(ro.BookName);


        }

    }
}


// Simple example of readonly

/*
using System;

public readonly struct Location
{
    // 1. Fields must be readonly
    public readonly double Lat;
    public readonly double Lng;

    // 2. Constructor is the ONLY place to set values
    public Location(double lat, double lng)
    {
        Lat = lat;
        Lng = lng;
    }

    public void Display() => Console.WriteLine($"At: {Lat}, {Lng}");
}

public class Program
{
    public static void Main()
    {
        Location home = new Location(18.52, 73.85);
        home.Display();

        // ATTEMPT TO CHANGE:
        // home.Lat = 19.07; 
        // ERROR: Cannot assign to 'Lat' because it is readonly.
        
        Console.WriteLine("The location is locked and cannot be changed!");
    }
}

// Output

At: 18.52, 73.85
The location is locked and cannot be changed!

*/