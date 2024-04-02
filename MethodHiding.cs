using System;

// Base class
public class Parent
{
    // Method
    public void ShowMessage()
    {
        Console.WriteLine("This is from the Parent class.");
    }
}

// Derived class
public class Child : Parent
{
    // Method hiding - hiding the base class method
    public new void ShowMessage()
    {
        Console.WriteLine("This is from the Child class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Creating objects of derived and base classes
        Parent parent = new Parent(); // Creating an object of the base class
        Child child = new Child(); // Creating an object of the derived class

        // Example 2: Calling methods
        parent.ShowMessage(); // Calling method of base class
        child.ShowMessage(); // Calling method of derived class

        // Example 3: Upcasting and calling methods
        Parent parentChild = new Child(); // Upcasting to the base class
        parentChild.ShowMessage(); // Calling method of base class (hiding behavior)
        Console.ReadLine();
    }
}
