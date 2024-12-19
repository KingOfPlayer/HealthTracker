using HealthTracker.Entities.Models.Device;

namespace HealthTracker.Services.Interfaces
{
    public interface IDeviceService
    {
        Task AddNewDevice(Device newDevice);
        Task<List<Device>> GetDeviceList();
        Task RemoveDevice(Guid guid);
    }
}