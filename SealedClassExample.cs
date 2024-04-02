using System;

// Base class
public class Animal
{
    // Method that can be overridden by derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

// Sealed derived class
public sealed class Dog : Animal
{
    // Sealed method, cannot be overridden by derived classes
    public sealed override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

// Derived class attempting to inherit from a sealed class (not allowed)
//public class Puppy : Dog // Uncommenting this line will result in a compilation error
//{
//    // Attempt to override the sealed method
//    public override void MakeSound()
//    {
//        Console.WriteLine("Puppy barks softly.");
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the sealed class
        Dog dog = new Dog();

        // Call the sealed method
        dog.MakeSound(); // Output: Dog barks.
        Console.ReadLine();
    }
}
