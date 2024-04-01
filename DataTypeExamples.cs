using System;

class Program
{
    static void Main(string[] args)
    {
        // Integer data types
        int integerNumber = 10;         // Represents whole numbers, e.g., 10, -5, 0
        uint unsignedInteger = 20;      // Represents non-negative whole numbers, e.g., 20, 100

        // Floating-point data types
        float floatingNumber = 3.14f;   // Represents single-precision floating-point numbers, e.g., 3.14, -2.5
        double doubleNumber = 2.71828;  // Represents double-precision floating-point numbers, e.g., 2.71828, -123.456

        // Boolean data type
        bool isTrue = true;             // Represents true or false values

        // Character data type
        char character = 'A';           // Represents a single Unicode character, e.g., 'A', 'b', '$'

        // String data type
        string text = "Hello, world!";  // Represents a sequence of characters, e.g., "Hello", "abc123"
        
        // Displaying values
        Console.WriteLine("Integer Number: " + integerNumber);
        Console.WriteLine("Unsigned Integer: " + unsignedInteger);
        Console.WriteLine("Floating Number: " + floatingNumber);
        Console.WriteLine("Double Number: " + doubleNumber);
        Console.WriteLine("Boolean Value: " + isTrue);
        Console.WriteLine("Character: " + character);
        Console.WriteLine("Text: " + text);
    }
}
