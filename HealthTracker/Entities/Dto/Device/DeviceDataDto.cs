using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Dto.Device
{
    public record DeviceDataDto(float Spo2, float Bpm, float Temp, float Humidity);
}
