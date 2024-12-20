using HealthTracker.Entities.Dto.Device;

namespace HealthTracker.Services.Interfaces
{
    public interface IDeviceDataService
    {
        Task CreateDeviceData(NewDeviceDataDto deviceDataDto, DeviceDetailsDto deviceDetailsDto);
        Task<IEnumerable<DeviceDataDto>> GetDeviceDatas(DeviceDetailsDto deviceDetailsDto);
    }
}
