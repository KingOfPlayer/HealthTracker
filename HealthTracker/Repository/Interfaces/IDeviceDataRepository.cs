using HealthTracker.Entities.Models.Device;

namespace HealthTracker.Repository.Interfaces
{
    public interface IDeviceDataRepository
    {
        Task CreateDeviceData(DeviceData DeviceData);
        IQueryable<DeviceData> GetAllDeviceDatas();
        IQueryable<DeviceData> GetDeviceDatas(int DeviceId);
        Task RemoveDeviceData(DeviceData DeviceData);
        Task UpdateDeviceData(DeviceData DeviceData);
    }
}
