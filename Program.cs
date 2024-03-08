class Program
{
    static void Main(string[] args)
    {
        IVehicle car = new Car();
        IVehicle bike = new Bike();

        VehicleBridge carBridge = new CarBridge(car);
        VehicleBridge bikeBridge = new BikeBridge(bike);

        carBridge.Operate();
        bikeBridge.Operate();

        Console.ReadKey();
    }
}
