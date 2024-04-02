using System;

// Class representing a person
public class Person
{
    // Fields to store person's name and age
    public string Name;
    public int Age;

    // Default constructor
    public Person()
    {
        Console.WriteLine("Default constructor called.");
        Name = "Dashrath";
        Age = 27;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        Console.WriteLine("Parameterized constructor called.");
        Name = name;
        Age = age;
    }

    // Copy constructor
    public Person(Person otherPerson)
    {
        Console.WriteLine("Copy constructor called.");
        Name = otherPerson.Name;
        Age = otherPerson.Age;
    }

    // Static constructor
    static Person()
    {
        Console.WriteLine("Static constructor called.");
    }

    // Destructor
    ~Person()
    {
        Console.WriteLine("Destructor called.");
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
        // Example 1: Default constructor
        Person person1 = new Person(); // Creating an object using default constructor
        person1.DisplayInfo();

        // Example 2: Parameterized constructor
        Person person2 = new Person("Ajay", 22); // Creating an object using parameterized constructor
        person2.DisplayInfo();

        // Example 3: Copy constructor
        Person person3 = new Person(person2); // Creating an object using copy constructor
        person3.DisplayInfo();
        Console.ReadLine();
    }
}
