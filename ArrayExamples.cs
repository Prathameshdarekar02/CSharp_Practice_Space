using System;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Storing student names
        string[] students = new string[3]; // Declaring an array to store names of 3 students

        // Getting names of students from the user
        Console.WriteLine("Enter the names of three students:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");
            students[i] = Console.ReadLine(); // Getting input and storing it in the array
        }

        // Displaying the list of students
        Console.WriteLine("\nList of Students:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // Example 2: Storing temperatures for a week
        double[] temperatures = { 25.5, 27.3, 26.8, 28.1, 24.9, 23.7, 26.0 }; // Array to store temperatures for 7 days

        // Calculating and displaying average temperature
        double totalTemperature = 0;
        foreach (double temp in temperatures)
        {
            totalTemperature += temp; // Accumulating total temperature
        }
        double averageTemperature = totalTemperature / temperatures.Length;
        Console.WriteLine($"\nAverage temperature for the week: {averageTemperature:F1} °C");

        // Example 3: Storing product prices
        decimal[] prices = new decimal[5]; // Array to store prices of 5 products

        // Getting prices of products from the user
        Console.WriteLine("\nEnter the prices of five products:");
        for (int i = 0; i < prices.Length; i++)
        {
            Console.Write($"Product {i + 1}: $");
            prices[i] = Convert.ToDecimal(Console.ReadLine()); // Getting input and storing it in the array
        }

        // Displaying the list of product prices
        Console.WriteLine("\nList of Product Prices:");
        foreach (decimal price in prices)
        {
            Console.WriteLine($"${price}");
        }
        Console.ReadLine();
}
