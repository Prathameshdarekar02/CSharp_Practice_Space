using System;

// Basic class representing a person
public class Person
{
    // Fields to store person's name and age
    public string Name; // Public field for name
    public int Age; // Public field for age

    // Constructor to initialize the person object with name and age
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to display person's information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Static class containing utility methods
public static class Utility
{
    // Static method to add two numbers
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Abstract class representing a geometric shape
public abstract class Shape
{
    // Abstract method to calculate the area of the shape
    public abstract double Area();
}

// Derived class (Inheritance) representing a rectangle
public class Rectangle : Shape
{
    // Properties to store length and width of the rectangle
    public double Length { get; set; } // Property for length
    public double Width { get; set; } // Property for width

    // Constructor to initialize the rectangle with length and width
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Overridden method to calculate the area of the rectangle
    public override double Area()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the basic class (Person)
        Person person1 = new Person("John", 30); // Creating a person object with name "John" and age 30
        person1.DisplayInfo(); // Calling method to display person's information

        // Calling a static method from the static class (Utility)
        double result = Utility.Add(5.5, 3.2); // Calling static method to add two numbers
        Console.WriteLine($"Addition result: {result}"); // Displaying the result of addition

        // Creating an instance of the derived class (Rectangle)
        Rectangle rectangle = new Rectangle(5, 3); // Creating a rectangle object with length 5 and width 3
        Console.WriteLine($"Area of rectangle: {rectangle.Area()}"); // Calling overridden method to calculate area
        Console.ReadLine();
    }
}
