using System;

public struct Meesho
{
    // private firlds
    private int _productID;
    private string _productName;
    private double _productPrice;

    // public constructore ( parameterized)
    public Meesho(int productID, string productName, double productPrice)
    {
        _productID = productID;
        _productName = productName;
        _productPrice = productPrice;
    }

    // public fields
    public int ProductID
    {
        set
        {
            if (value >= 1 && value <= 100)
            {
                _productID = value;
            }
        }
        get
        {
            return _productID;
        }
    }

    public string ProductName
    {
        set
        {
            if (value.Length <= 15)
            {
                _productName = value;
            }
            else
            {
                Console.WriteLine("Name of product is too long to store");
            }
        }
        get
        {
            return _productName;
        }
    }

    public double ProductPrice
    {
        set
        {
            if (value >= 100 && value <= 10000)
            {
                _productPrice = value;
            }
        }
        get
        {
            return _productPrice;
        }
    }

    public string GetProductInfo()
    {
        // Using string interpolation to return the info
        return $"ID: {_productID}, Name: {_productName}, Price: Rs.{_productPrice}";
    }

    public static void Main(string[] args)
    {
        //Meesho m = new Meesho(); //The new keyword for a struct simply tells the compiler to initialize all fields.
        // As a constructor is created 
        Meesho m = new Meesho(50, "BodyConDress", 500);

        //m.ProductID = 50;
        //m.ProductName = "BodyConDress";
        //m.ProductPrice = 500;

        Console.WriteLine(m.GetProductInfo());

        Console.WriteLine("\n-----------------------------\n");

        // create struct instance
        //ReadOnlyExample ro = new ReadOnlyExample("Akanksha");

        //ro.GetBookName();
        //Console.WriteLine(ro.BookName);


    }
}