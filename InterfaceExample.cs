using System;

// Interface defining a shape
public interface IShape
{
    // Method to calculate area
    double CalculateArea();

    // Property to get the name of the shape
    string Name { get; }
}

// Interface defining a drawable shape
public interface IDrawable
{
    // Method to draw the shape
    void Draw();
}

// Class representing a rectangle that implements both interfaces
public class Rectangle : IShape, IDrawable
{
    // Fields for length and width
    private double length;
    private double width;

    // Constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implementation of CalculateArea method
    public double CalculateArea()
    {
        return length * width;
    }

    // Implementation of Name property
    public string Name
    {
        get { return "Rectangle"; }
    }

    // Implementation of Draw method
    public void Draw()
    {
        Console.WriteLine($"Drawing a {Name} with length {length} and width {width}...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of Rectangle
        Rectangle rectangle = new Rectangle(5, 3);

        // Calling methods defined in the interfaces
        double area = rectangle.CalculateArea();
        Console.WriteLine($"Area of {rectangle.Name}: {area}");

        rectangle.Draw();
        Console.ReadLine();
    }
}
