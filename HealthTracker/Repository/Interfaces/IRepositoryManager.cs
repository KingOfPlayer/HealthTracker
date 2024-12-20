namespace HealthTracker.Repository.Interfaces
{
    public interface IRepositoryManager
    {
        IDeviceRepository DeviceRepository { get; }
        IDeviceDataRepository DeviceDataRepository { get; }
    }
}
