using System;

public abstract class Student
{
    public abstract int Marks { get; set; }
}

public class GraduateStudent : Student
{
    public override int Marks { get; set; }
}

public class PostGraduateStudent : Student
{
    public override int Marks { get; set; }
}

//generic class with constraints (want to accept Student or its child classes only)
public class MarksPrinter<T> where T : Student
{
    public T stu;

    public void PrintMarks()
    {
        Student temp = stu as Student;
        System.Console.WriteLine(temp.Marks);
    }
}


// -----------------Generic Methods-------------------
public class Employee
{
    public int Salary;
}

public class StudentMethod
{
    public int Marks;
}

//a class with generic method
public class Sample
{
    //generic method
    public void PrintData<T>(T obj) where T : class
    {
        if (obj.GetType() == typeof(StudentMethod))
        {
            StudentMethod temp = obj as StudentMethod;
            System.Console.WriteLine(temp.Marks);
        }
        else if (obj.GetType() == typeof(Employee))
        {
            Employee temp = obj as Employee;
            System.Console.WriteLine(temp.Salary);
        }
    }
}

/*
 using System;

public class User<T,T1> where T : struct
{
    public T Registration;
    public T1 Age;  

    public void show()
    {
        Console.WriteLine("Registration is:"+Registration);
        Console.WriteLine("Age is :"+ Age);
    }

    // Generic method 
    public static bool AreEqual<T3>(T a , T b)
    {
        return a.Equals(b);
    }
}


class Program
{
    static void Main()
    {
        User<bool,int> ui = new User<bool,int>();
        ui.Registration = true;
        ui.Age = 21;
        ui.show();
        
        User<int,int>u = new User<int,int>();
        u.Registration = 23;
        u.Age = 22;
        u.show();

        // User<int, int> u2 = new User<int, int>();
        User<int,long>.AreEqual<int>(10, 10);  //Generic method call


    }
}
*/