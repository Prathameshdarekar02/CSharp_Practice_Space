using System;

// Base class
public class Shape
{
    // Fields
    protected double width;
    protected double height;

    // Constructor
    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Method to display information about the shape
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Width: {width}, Height: {height}");
    }
}

// Derived class (Inheritance)
public class Rectangle : Shape
{
    // Constructor
    public Rectangle(double width, double height) : base(width, height)
    {
    }

    // Method to calculate area (overrides base class method)
    public override void DisplayInfo()
    {
        Console.WriteLine("Rectangle:");
        base.DisplayInfo();
        Console.WriteLine($"Area: {width * height}");
    }
}

// Derived class (Inheritance)
public class Triangle : Shape
{
    // Constructor
    public Triangle(double width, double height) : base(width, height)
    {
    }

    // Method to calculate area (overrides base class method)
    public override void DisplayInfo()
    {
        Console.WriteLine("Triangle:");
        base.DisplayInfo();
        Console.WriteLine($"Area: {(width * height) / 2}");
    }
}

// Derived class (Inheritance)
public class Circle : Shape
{
    // Constructor
    public Circle(double radius) : base(radius * 2, radius * 2)
    {
    }

    // Method to calculate area (overrides base class method)
    public override void DisplayInfo()
    {
        Console.WriteLine("Circle:");
        Console.WriteLine($"Radius: {width / 2}");
        Console.WriteLine($"Area: {Math.PI * (width / 2) * (width / 2)}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Creating objects of derived classes
        Rectangle rectangle = new Rectangle(5, 3);
        Triangle triangle = new Triangle(4, 6);
        Circle circle = new Circle(4);

        // Example 2: Using inherited methods
        rectangle.DisplayInfo();
        triangle.DisplayInfo();
        circle.DisplayInfo();
        Console.ReadLine();
    }
}
