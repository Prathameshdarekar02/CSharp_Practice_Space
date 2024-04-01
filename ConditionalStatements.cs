using System;

class Program
{
    static void Main(string[] args)
    {
        // Example: Checking if a number is positive, negative, or zero
        int number = 10;

        // If statement to check if number is positive
        if (number > 0)
        {
            Console.WriteLine("Number is positive");
            Console.WriteLine();
        }
        // Else statement if number is not positive
        else
        {
            // Nested if-else to check if number is zero or negative
            if (number == 0)
            {
                Console.WriteLine("Number is zero");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Number is negative");
                Console.WriteLine();
            }
        }

        // Example: Determining grade based on score
        int score = 85;

        // Else-if ladder to determine grade based on score
        if (score >= 90)
        {
            Console.WriteLine("Grade: A");
            Console.WriteLine();
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade: B");
            Console.WriteLine();
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Grade: D");
            Console.WriteLine();
        }

        // Example: Checking day of the week using switch statement
        int day = 3;
        string dayOfWeek;

        // Switch statement to determine the day of the week
        switch (day)
        {
            case 1:
                dayOfWeek = "Monday";
                break;
            case 2:
                dayOfWeek = "Tuesday";
                break;
            case 3:
                dayOfWeek = "Wednesday";
                break;
            case 4:
                dayOfWeek = "Thursday";
                break;
            case 5:
                dayOfWeek = "Friday";
                break;
            case 6:
                dayOfWeek = "Saturday";
                break;
            case 7:
                dayOfWeek = "Sunday";
                break;
            default:
                dayOfWeek = "Invalid day";
                break;
        }

        Console.WriteLine($"Today is {dayOfWeek}");
        Console.WriteLine();
        Console.ReadLine();
    }
}
