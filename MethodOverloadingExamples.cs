using System;

// Class with method overloading
public class Calculator
{
    // Method with no parameters
    public void Add()
    {
        Console.WriteLine("No parameters: 0");
    }

    // Method with one integer parameter
    public void Add(int num)
    {
        Console.WriteLine($"One integer parameter: {num}");
    }

    // Method with two integer parameters
    public void Add(int num1, int num2)
    {
        Console.WriteLine($"Two integer parameters: {num1 + num2}");
    }

    // Method with two double parameters
    public void Add(double num1, double num2)
    {
        Console.WriteLine($"Two double parameters: {num1 + num2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object of the Calculator class
        Calculator calculator = new Calculator();

        // Example 1: Calling method with no parameters
        calculator.Add();

        // Example 2: Calling method with one integer parameter
        calculator.Add(5);

        // Example 3: Calling method with two integer parameters
        calculator.Add(3, 7);

        // Example 4: Calling method with two double parameters
        calculator.Add(3.5, 2.7);
        Console.ReadLine();
    }
}
