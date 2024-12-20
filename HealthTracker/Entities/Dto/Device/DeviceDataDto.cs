using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Dto.Device
{
    public record DeviceDataDto(float Spo2, int Bpm, int Temp, int Humidity);
    public record NewDeviceDataDto(float Spo2,int Bpm,int Temp,int Humidity,Guid DeviceGuid);
}
