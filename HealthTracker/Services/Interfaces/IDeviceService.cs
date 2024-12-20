using HealthTracker.Entities.Dto.Device;

namespace HealthTracker.Services.Interfaces
{
    public interface IDeviceService
    {
        Task AddNewDevice(NewDeviceDto newDeviceDto);
        Task<IEnumerable<DeviceDto>> GetDeviceList();
        Task RemoveDevice(DeviceGuidDto deviceGuidDto);
    }
}