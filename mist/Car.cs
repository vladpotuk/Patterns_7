using System;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving...");
    }

    public void Park()
    {
        Console.WriteLine("Car is parking...");
    }
}
