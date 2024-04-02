using System;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Boxing
        int num1 = 10; // Declaring and initializing a value type variable
        object obj1 = num1; // Boxing: Converting value type to reference type
        Console.WriteLine($"Value of num1: {num1}"); // Displaying the value of num1
        Console.WriteLine($"Value of obj1 after boxing: {obj1}"); // Displaying the value of obj1 after boxing

        // Example 2: Unboxing
        object obj2 = 20; // Declaring and initializing a reference type variable
        int num2 = (int)obj2; // Unboxing: Converting reference type to value type
        Console.WriteLine($"\nValue of obj2: {obj2}"); // Displaying the value of obj2
        Console.WriteLine($"Value of num2 after unboxing: {num2}"); // Displaying the value of num2 after unboxing

        // Example 3: Demonstration of boxing and unboxing with arrays
        int[] numbers = { 1, 2, 3, 4, 5 }; // Declaring and initializing a value type array
        object boxedArray = numbers; // Boxing: Converting value type array to reference type
        int[] unboxedArray = (int[])boxedArray; // Unboxing: Converting reference type array to value type
        Console.WriteLine($"\nValue of numbers: [{string.Join(", ", numbers)}]"); // Displaying the values of the original array
        Console.WriteLine($"Value of boxedArray after boxing: {boxedArray}"); // Displaying the value of boxedArray after boxing
        Console.WriteLine($"Value of unboxedArray after unboxing: [{string.Join(", ", unboxedArray)}]"); // Displaying the values of the unboxed array
        Console.ReadLine();
    }
}
