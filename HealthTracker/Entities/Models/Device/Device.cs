using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Models.Device
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public Guid DeviceGuid { get; set; }
        [Required]
        public required string DeviceName { get; set; }
        public ICollection<DeviceData>? DeviceData { get; set; }
    }
}
