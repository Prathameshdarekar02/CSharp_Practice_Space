using System;

// Interface representing a vehicle
public interface IVehicle
{
    void Start(); // Method to start the vehicle
    void Stop(); // Method to stop the vehicle
}

// Interface representing a flying vehicle
public interface IFlyable
{
    void TakeOff(); // Method to take off
    void Land(); // Method to land
}

// Interface representing a land vehicle
public interface ILandVehicle
{
    void Drive(); // Method to drive the vehicle
}

// Class representing a car
public class Car : IVehicle, ILandVehicle
{
    // Implementation of IVehicle interface
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    // Implementation of ILandVehicle interface
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

// Class representing an airplane
public class Airplane : IVehicle, IFlyable
{
    // Implementation of IVehicle interface
    public void Start()
    {
        Console.WriteLine("Airplane started.");
    }

    public void Stop()
    {
        Console.WriteLine("Airplane stopped.");
    }

    // Implementation of IFlyable interface
    public void TakeOff()
    {
        Console.WriteLine("Airplane took off.");
    }

    public void Land()
    {
        Console.WriteLine("Airplane landed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Using a car object
        Car car = new Car();
        car.Start(); // Start the car
        car.Drive(); // Drive the car
        car.Stop(); // Stop the car

        // Example 2: Using an airplane object
        Airplane airplane = new Airplane();
        airplane.Start(); // Start the airplane
        airplane.TakeOff(); // Take off the airplane
        airplane.Land(); // Land the airplane
        airplane.Stop(); // Stop the airplane
        Console.ReadLine();
    }
}
