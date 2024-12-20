using HealthTracker.Entities.Dto.Device;

namespace HealthTracker.Services.Interfaces
{
    public interface IDeviceDataService
    {
        Task CreateDeviceData(DeviceDataDto deviceDataDto, DeviceDetailsDto deviceDetailsDto);
    }
}
