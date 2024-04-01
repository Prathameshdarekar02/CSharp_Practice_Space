using System;

class Program
{
    // Example 1: Instance Method
    // Instance method to greet a person
    public void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // Example 2: Static Method
    // Static method to calculate the area of a rectangle
    public static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    // Example 3: Parameterized Method
    // Parameterized method to add two numbers
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Example 4: Method with Return Value
    // Method to check if a number is even
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Example 5: Method Overloading
    // Overloaded method to add two decimal numbers
    public decimal Add(decimal num1, decimal num2)
    {
        return num1 + num2;
    }

    // Overloaded method to add three decimal numbers
    public decimal Add(decimal num1, decimal num2, decimal num3)
    {
        return num1 + num2 + num3;
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        // Example 1: Calling Instance Method
        program.Greet("Prathamesh");

        // Example 2: Calling Static Method
        double area = Program.CalculateArea(5, 3);
        Console.WriteLine($"Area of rectangle: {area}");

        // Example 3: Calling Parameterized Method
        int sum = program.Add(3, 4);
        Console.WriteLine($"Sum: {sum}");

        // Example 4: Calling Method with Return Value
        int number = 7;
        bool isEven = program.IsEven(number);
        Console.WriteLine($"{number} is{(isEven ? "" : " not")} even");

        // Example 5: Calling Method Overloading
        decimal result1 = program.Add(2.5m, 3.7m);
        Console.WriteLine($"Sum of two numbers: {result1}");

        decimal result2 = program.Add(1.2m, 2.3m, 3.4m);
        Console.WriteLine($"Sum of three numbers: {result2}");
        Console.ReadLine();
    }
}
