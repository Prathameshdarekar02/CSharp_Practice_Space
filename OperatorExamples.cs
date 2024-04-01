using System;

class Program
{
    static void Main(string[] args)
    {
        // Arithmetic Operators
        int a = 10;
        int b = 5;
        int additionResult = a + b;    // Addition
        int subtractionResult = a - b; // Subtraction
        int multiplicationResult = a * b; // Multiplication
        int divisionResult = a / b;    // Division
        int modulusResult = a % b;      // Modulus

        // Outputting results
        Console.WriteLine($"Addition Result: {additionResult}");
        Console.WriteLine($"Subtraction Result: {subtractionResult}");
        Console.WriteLine($"Multiplication Result: {multiplicationResult}");
        Console.WriteLine($"Division Result: {divisionResult}");
        Console.WriteLine($"Modulus Result: {modulusResult}");
        Console.WriteLine();




        // Assignment Operator
        int c = 20; // Assignment
        Console.WriteLine();




        // Relational Operators
        bool isEqual = (a == b);   // Equal to
        bool isNotEqual = (a != b); // Not equal to
        bool isGreater = (a > b);   // Greater than
        bool isLess = (a < b);      // Less than
        bool isGreaterOrEqual = (a >= b); // Greater than or equal to
        bool isLessOrEqual = (a <= b);    // Less than or equal to

        // Outputting results
        Console.WriteLine($"Is Equal: {isEqual}");
        Console.WriteLine($"Is Not Equal: {isNotEqual}");
        Console.WriteLine($"Is Greater: {isGreater}");
        Console.WriteLine($"Is Less: {isLess}");
        Console.WriteLine($"Is Greater Or Equal: {isGreaterOrEqual}");
        Console.WriteLine($"Is Less Or Equal: {isLessOrEqual}");
        Console.WriteLine();




        // Logical Operators
        bool logicalAnd = (a > 0 && b > 0); // Logical AND
        bool logicalOr = (a > 0 || b > 0);  // Logical OR
        bool logicalNot = !(a > 0);         // Logical NOT

        // Outputting results
        Console.WriteLine($"Logical AND: {logicalAnd}");
        Console.WriteLine($"Logical OR: {logicalOr}");
        Console.WriteLine($"Logical NOT: {logicalNot}");
        Console.WriteLine();



        // Conditional Operator
        string result = (a > b) ? "a is greater than b" : "b is greater than or equal to a";

        // Outputting results
        Console.WriteLine($"Result: {result}");
        Console.WriteLine();




        // Null-Coalescing Operator
        int? nullableValue = null;
        int value = nullableValue ?? -1; // If nullableValue is null, use -1 as the value

        // Outputting results
        Console.WriteLine($"Nullable Value: {value}");
        Console.WriteLine();
        
        Console.ReadLine();
    }
}
