using System;

// Class representing a complex number
public class ComplexNumber
{
    // Fields to store real and imaginary parts
    private double real;
    private double imaginary;

    // Constructor
    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    // Method to display the complex number
    public void Display()
    {
        Console.WriteLine($"{real} + {imaginary}i");
    }

    // Operator overloading for addition
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        double realPart = c1.real + c2.real;
        double imaginaryPart = c1.imaginary + c2.imaginary;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    // Operator overloading for subtraction
    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        double realPart = c1.real - c2.real;
        double imaginaryPart = c1.imaginary - c2.imaginary;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    // Operator overloading for multiplication
    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        double realPart = (c1.real * c2.real) - (c1.imaginary * c2.imaginary);
        double imaginaryPart = (c1.real * c2.imaginary) + (c1.imaginary * c2.real);
        return new ComplexNumber(realPart, imaginaryPart);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating complex numbers
        ComplexNumber c1 = new ComplexNumber(3, 2);
        ComplexNumber c2 = new ComplexNumber(1, 4);

        // Example 1: Addition
        ComplexNumber sum = c1 + c2;
        Console.Write("Addition result: ");
        sum.Display();

        // Example 2: Subtraction
        ComplexNumber difference = c1 - c2;
        Console.Write("Subtraction result: ");
        difference.Display();

        // Example 3: Multiplication
        ComplexNumber product = c1 * c2;
        Console.Write("Multiplication result: ");
        product.Display();
        Console.ReadLine();
    }
}
