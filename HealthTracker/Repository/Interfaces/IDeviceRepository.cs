using HealthTracker.Entities.Models.Device;

namespace HealthTracker.Repository.Interfaces
{
    public interface IDeviceRepository
    {
        void CreateDevice(Device device);
        void UpdateDevice(Device device);
        void RemoveDevice(Device device);

        IQueryable<Device> GetDevices();

        IQueryable<Device> GetDevice(Guid guid);
    }
}
