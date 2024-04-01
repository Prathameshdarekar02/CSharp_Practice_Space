using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicit Conversion
        int intValue = 10;
        double doubleValue = intValue; // Implicit conversion from int to double
        Console.WriteLine("Implicit conversion from int to double: " + doubleValue);

        // Explicit Conversion
        double anotherDoubleValue = 3.14;
        int anotherIntValue = (int)anotherDoubleValue; // Explicit conversion from double to int
        Console.WriteLine("Explicit conversion from double to int: " + anotherIntValue);

        // Conversion with Data Loss
        double largeDoubleValue = 123456789.123456789;
        int largeIntValue = (int)largeDoubleValue; // Explicit conversion from double to int with potential data loss
        Console.WriteLine("Explicit conversion from double to int with potential data loss: " + largeIntValue);

        // Overflow Example
        int maxIntValue = int.MaxValue;
        int overflowIntValue = checked(maxIntValue + 1); // This causes overflow
        Console.WriteLine("Overflow example: " + overflowIntValue);

        // Numeric Type Conversion
        long longValue = 1234567890123456789;
        float floatValue = longValue; // Implicit conversion from long to float
        Console.WriteLine("Implicit conversion from long to float: " + floatValue);

        // Enum Conversion
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    int dayValue = (int)Days.Wednesday; // Explicit conversion from enum to int
    Console.WriteLine("Explicit conversion from enum to int: " + dayValue);

        Days anotherDay = (Days)3; // Explicit conversion from int to enum
    Console.WriteLine("Explicit conversion from int to enum: " + (Days)3); // Corrected output

        // Nullable Types Conversion
        int? nullableInt = 10; // Nullable int
    int regularInt = nullableInt ?? 0; // Using null coalescing operator to assign a default value
    Console.WriteLine("Nullable int with default value: " + regularInt);

        nullableInt = null; // Assigning a null value to nullable int
        int? intValueFromNullable = nullableInt ?? -1; // Using null coalescing operator with a nullable default value
    Console.WriteLine("Value of nullable int (with default value): " + (intValueFromNullable.HasValue? intValueFromNullable.ToString() : "null"));
    }
}
