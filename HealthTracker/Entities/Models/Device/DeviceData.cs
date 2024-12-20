using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Models.Device
{
    public class DeviceData
    {
        [Key]
        public int DeviceDataId { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
        public float Spo2 { get; set; }
        public float Bpm { get; set; }
        public float Temp { get; set; }
        public float Humidity {  get; set; }
    }
}
