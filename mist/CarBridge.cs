public class CarBridge : VehicleBridge
{
    public CarBridge(IVehicle vehicle) : base(vehicle)
    {
    }

    public override void Operate()
    {
        Console.WriteLine("Operating car:");
        _vehicle.Drive();
        _vehicle.Park();
    }
}
