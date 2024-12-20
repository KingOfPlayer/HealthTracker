namespace HealthTracker.Services.Interfaces
{
    public interface IServiceManager
    {
        IDeviceService DeviceService { get; }
        IDeviceDataService DeviceDataService { get; }
    }
}
