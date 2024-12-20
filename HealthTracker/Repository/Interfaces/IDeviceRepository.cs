using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;

namespace HealthTracker.Repository.Interfaces
{
    public interface IDeviceRepository
    {
        Task CreateDevice(Device device);
        Task UpdateDevice(Device device);
        Task RemoveDevice(Device device);
        Task RemoveDevice(Guid guid);

        IQueryable<Device> GetDevices();

        Task<bool> DeviceIsExists(Guid guid);
        IQueryable<Device> GetDevice(Guid guid);
    }
}
