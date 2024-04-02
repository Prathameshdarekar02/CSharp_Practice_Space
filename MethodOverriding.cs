using System;

// Base class
public class Shape
{
    // Method to calculate area
    public virtual void CalculateArea()
    {
        Console.WriteLine("Calculating area in the Shape class.");
    }
}

// Derived class 1
public class Rectangle : Shape
{
    // Method overriding - providing specific implementation for CalculateArea
    public override void CalculateArea()
    {
        Console.WriteLine("Calculating area of rectangle: Length * Width");
    }
}

// Derived class 2
public class Triangle : Shape
{
    // Method overriding - providing specific implementation for CalculateArea
    public override void CalculateArea()
    {
        Console.WriteLine("Calculating area of triangle: (Base * Height) / 2");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Creating objects of derived classes
        Rectangle rectangle = new Rectangle(); // Creating an object of Rectangle class
        Triangle triangle = new Triangle(); // Creating an object of Triangle class

        // Example 2: Calling overridden methods
        rectangle.CalculateArea(); // Calling overridden method of Rectangle class
        triangle.CalculateArea(); // Calling overridden method of Triangle class
        Console.ReadLine();
    }
}
