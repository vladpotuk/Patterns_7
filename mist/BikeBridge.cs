public class BikeBridge : VehicleBridge
{
    public BikeBridge(IVehicle vehicle) : base(vehicle)
    {
    }

    public override void Operate()
    {
        Console.WriteLine("Operating bike:");
        _vehicle.Drive();
        _vehicle.Park();
    }
}
