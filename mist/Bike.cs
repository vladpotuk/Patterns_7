using System;

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Bike is driving...");
    }

    public void Park()
    {
        Console.WriteLine("Bike is parking...");
    }
}
