using HealthTracker.Entities.Dto.Device;

namespace HealthTracker.Services.Interfaces
{
    public interface IDeviceService
    {
        Task AddNewDevice(DeviceNameDto newDeviceDto);
        Task<DeviceDetailsDto?> GetDeviceDetails(DeviceGuidDto deviceGuidDto);
        Task<IEnumerable<DeviceDto>> GetDeviceList();
        Task RemoveDevice(DeviceGuidDto deviceGuidDto);
    }
}