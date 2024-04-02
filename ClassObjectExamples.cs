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

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Creating an object of a basic class
        Person person1 = new Person("Dashrath", 27); // Creating an object of the Person class
        person1.DisplayInfo(); // Calling method to display person's information

        // Example 2: Creating multiple objects of the same class
        Person person2 = new Person("Ajay", 22); // Creating another object of the Person class
        person2.DisplayInfo();

        Person person3 = new Person("Rohit", 25); // Creating another object of the Person class
        person3.DisplayInfo();

        // Example 3: Creating objects of different types
        string message = "Hello, World!"; // Creating an object of string type
        DateTime currentDate = DateTime.Now; // Creating an object of DateTime type

        // Example 4: Creating and using objects with properties
        Rectangle rectangle = new Rectangle(); // Creating an object of Rectangle class
        rectangle.Length = 5; // Setting the value of Length property
        rectangle.Width = 3; // Setting the value of Width property
        double area = rectangle.Area(); // Calling method to calculate area
        Console.WriteLine($"Area of rectangle: {area}");

        // Example 5: Creating and using objects with constructors
        Employee employee1 = new Employee("Rohit", 50000); // Creating an object of Employee class with constructor
        employee1.DisplayInfo(); // Calling method to display employee's information
    }
}

// Class representing a geometric shape
public class Rectangle
{
    // Properties to store length and width of the rectangle
    public double Length { get; set; } // Property for length
    public double Width { get; set; } // Property for width

    // Method to calculate the area of the rectangle
    public double Area()
    {
        return Length * Width;
    }
}

// Class representing an employee
public class Employee
{
    // Properties to store employee's name and salary
    public string Name { get; set; } // Property for name
    public double Salary { get; set; } // Property for salary

    // Constructor to initialize employee object with name and salary
    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    // Method to display employee's information
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}, Salary: ${Salary}");
        Console.ReadLine();
    }
}
