using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Dto.Device
{
    public record DeviceDto(Guid DeviceGuid, string DeviceName);
    public record DeviceDetailsDto(int DeviceId,Guid DeviceGuid, string DeviceName);
    public record DeviceNameDto(string DeviceName);
    public record DeviceGuidDto(Guid DeviceGuid);
}
