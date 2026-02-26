using System;

namespace GenericClassExample
{
    // The generic class definition
    public class MITAOE<T1, T2, T3>
    {
        public T1 _studentID; // Changed to public for access from Program class
        public T2 studentName;
        public T3 result;
    }

    // This non-generic class serves as the Entry Point for the application
    class Program
    {
        static void Main(string[] args)
        {
            // Instance 1
            MITAOE<int, string, bool> m1 = new MITAOE<int, string, bool>();
            m1._studentID = 101;
            m1.studentName = "Akanksha";
            m1.result = true;

            // Instance 2
            MITAOE<int, string, bool> m2 = new MITAOE<int, string, bool>();
            m2._studentID = 103;
            m2.studentName = "Girish";
            m2.result = false;

            // Instance 3
            MITAOE<int, string, bool> m3 = new MITAOE<int, string, bool>();
            m3._studentID = 105;
            m3.studentName = "Omkar";
            m3.result = true;

            // Instance 4
            MITAOE<int, string, bool> m4 = new MITAOE<int, string, bool>();
            m4._studentID = 107;
            m4.studentName = "Riya";
            m4.result = true;

            // Output formatting
            Console.WriteLine("Student 1: " + m1._studentID + ", " + m1.studentName + ", Passed the Final Year: " + m1.result);
            Console.WriteLine("Student 2: " + m2._studentID + ", " + m2.studentName + ", Passed the Final Year: " + m2.result);
            Console.WriteLine("Student 3: " + m3._studentID + ", " + m3.studentName + ", Passed the Final Year: " + m3.result);
            Console.WriteLine("Student 4: " + m4._studentID + ", " + m4.studentName + ", Passed the Final Year: " + m4.result);

            // To keep the console window open
            Console.ReadLine();

            // Clear screen 
            Console.Clear();

            //----------------------------Generic Constraints-------------------

            //create object of generic class
            Console.WriteLine("Output for Generic Constraints code");
            MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent>();
            mp.stu = new GraduateStudent() { Marks = 80 };
            mp.PrintMarks();
            Console.ReadKey();

            Console.Clear();

            //---------------------------Generic Methods-------------------------

            //create objects
            Console.WriteLine("Output for Generic Methods code");
            Sample sample = new Sample();
            Employee emp = new Employee() { Salary = 1000 };
            StudentMethod stu = new StudentMethod() { Marks = 80 };

            //call the generic method
            sample.PrintData<Employee>(emp);
            sample.PrintData<StudentMethod>(stu);

            System.Console.ReadKey();


        }
    }
}


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Instance 1
//            MITAOE<int, string, bool> m1 = new MITAOE<int, string, bool>();
//            m1._studentID = 101;
//            m1.studentName = "Akanksha";
//            m1.result = true;

//            // Instance 2
//            MITAOE<int, string, bool> m2 = new MITAOE<int, string, bool>();
//            m2._studentID = 103;
//            m2.studentName = "Girish";
//            m2.result = false;

//            // Instance 3
//            MITAOE<int, string, bool> m3 = new MITAOE<int, string, bool>();
//            m3._studentID = 105;
//            m3.studentName = "Omkar";
//            m3.result = true;

//            // Instance 4 (Newly Added)
//            MITAOE<int, string, bool> m4 = new MITAOE<int, string, bool>();
//            m4._studentID = 107;
//            m4.studentName = "Riya";
//            m4.result = true;

//            // Printing results
//            PrintStudent(m1);
//            PrintStudent(m2);
//            PrintStudent(m3);
//            PrintStudent(m4);
//        }

//        // Helper method to keep the code clean
//        static void PrintStudent(MITAOE<int, string, bool> m)
//        {
//            Console.WriteLine($"ID: {m._studentID} | Name: {m.studentName} | Passed Final Year: {m.result}");
//        }
//    }
//}


