using System;

// Abstract class representing a shape
public abstract class Shape
{
    // Abstract method to calculate the area
    public abstract double Area();

    // Non-abstract method to display information about the shape
    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

// Derived class representing a rectangle
public class Rectangle : Shape
{
    // Fields for length and width
    private double length;
    private double width;

    // Constructor to initialize length and width
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implementation of abstract method to calculate the area of the rectangle
    public override double Area()
    {
        return length * width;
    }
}

// Derived class representing a circle
public class Circle : Shape
{
    // Field for radius
    private double radius;

    // Constructor to initialize the radius
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementation of abstract method to calculate the area of the circle
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Creating objects of derived classes
        Rectangle rectangle = new Rectangle(5, 3);
        Circle circle = new Circle(4);

        // Example 2: Calling methods
        rectangle.Display(); // Non-abstract method call to display shape information
        Console.WriteLine($"Area of rectangle: {rectangle.Area()}"); // Calling overridden method to calculate rectangle area

        circle.Display(); // Non-abstract method call to display shape information
        Console.WriteLine($"Area of circle: {circle.Area()}"); // Calling overridden method to calculate circle area
        Console.ReadLine();
    }
}
