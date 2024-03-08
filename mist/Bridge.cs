public abstract class VehicleBridge
{
    protected IVehicle _vehicle;

    protected VehicleBridge(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public abstract void Operate();
}
