using System;

// Define a custom namespace
namespace MyNamespace
{
    // Define a class within the namespace
    public class MyClass
    {
        // Method within the class
        public void MyMethod()
        {
            Console.WriteLine("Method from MyNamespace.MyClass");
        }
    }
}

// Define another namespace
namespace AnotherNamespace
{
    // Define a class within the namespace
    public class MyClass
    {
        // Method within the class
        public void MyMethod()
        {
            Console.WriteLine("Method from AnotherNamespace.MyClass");
        }
    }
}

// Main entry point of the program
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of MyClass from MyNamespace
        MyNamespace.MyClass myClass1 = new MyNamespace.MyClass();
        // Call MyMethod from MyNamespace
        myClass1.MyMethod(); // Output: Method from MyNamespace.MyClass

        // Create an instance of MyClass from AnotherNamespace
        AnotherNamespace.MyClass myClass2 = new AnotherNamespace.MyClass();
        // Call MyMethod from AnotherNamespace
        myClass2.MyMethod(); // Output: Method from AnotherNamespace.MyClass
        Console.ReadLine();
    }
}
