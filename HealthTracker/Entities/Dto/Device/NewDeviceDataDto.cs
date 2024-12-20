using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Dto.Device
{
    public record NewDeviceDataDto(float Spo2, float Bpm, float Temp, float Humidity);
    public record DeviceDataDto(DateTime DateTime, float Spo2, float Bpm, float Temp, float Humidity);
}
