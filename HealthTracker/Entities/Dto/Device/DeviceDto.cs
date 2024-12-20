using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Dto.Device
{
    public record DeviceDto(Guid DeviceGuid, string DeviceName);
    public record NewDeviceDto(string DeviceName);
    public record DeviceGuidDto(Guid DeviceGuid);
}
