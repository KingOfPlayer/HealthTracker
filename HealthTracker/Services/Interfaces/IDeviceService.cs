using HealthTracker.Entities.Models.Device;

namespace HealthTracker.Services.Interfaces
{
    public interface IDeviceService
    {
        void AddNewDevice(Device newDevice);
        List<Device> GetDeviceList();
    }
}