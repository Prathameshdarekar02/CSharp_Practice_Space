using System;

class Program
{
    static void Main(string[] args)
    {
        // Example: Using for loop to print numbers from 1 to 5
        Console.WriteLine("Using for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // Example: Using while loop to print numbers from 1 to 5
        Console.WriteLine("\nUsing while loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        // Example: Using do-while loop to print numbers from 1 to 5
        Console.WriteLine("\nUsing do-while loop:");
        int k = 1;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k <= 5);

        // Example: Using foreach loop to iterate over elements in an array
        Console.WriteLine("\nUsing foreach loop:");
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.ReadLine();
    }
}
