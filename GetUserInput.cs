using System;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Getting user's name
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine(); // Getting user input
        Console.WriteLine($"Hello, {name}!");

        // Example 2: Getting user's age
        Console.WriteLine("\nPlease enter your age:");
        int Age = Convert.ToInt32(Console.ReadLine()); // Getting user input and converting to integer
        Console.WriteLine($"You are {Age} years old.");

        // Example 3: Getting user's email address
        Console.WriteLine("\nPlease enter your email address:");
        string email = Console.ReadLine(); // Getting user input
        Console.WriteLine($"Your email address is: {email}");

        // Example 4: Getting user's favorite color
        Console.WriteLine("\nPlease enter your favorite color:");
        string favoriteColor = Console.ReadLine(); // Getting user input
        Console.WriteLine($"Your favorite color is: {favoriteColor}");
        Console.WriteLine();

        // Example: Getting user's age with error handling
        Console.WriteLine("Please enter your age:");
        string Input = Console.ReadLine(); // Get user input as string

        int age;
        if (int.TryParse(Input, out age)) // Attempt to parse input to integer
        {
            if (age >= 0 && age <= 120) // Check if the input is a valid age
            {
                Console.WriteLine($"Your age is: {age}");
                if (age < 18)
                {
                    Console.WriteLine("You are under 18 years old.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior citizen.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a valid age between 0 and 120.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric age.");
        }
        Console.ReadLine();
    }
}
