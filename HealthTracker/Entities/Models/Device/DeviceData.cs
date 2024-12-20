using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Models.Device
{
    public class DeviceData
    {
        [Key]
        public int DeviceDataId { get; set; }
        public float Spo2 { get; set; }
        public int Bpm { get; set; }
        public int Temp { get; set; }
        public int Humidity {  get; set; }
        public Guid DeviceGuid { get; set; }
        public required Device Device { get; set; }
    }
}
