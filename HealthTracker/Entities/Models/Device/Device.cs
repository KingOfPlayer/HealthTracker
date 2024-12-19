using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Models.Device
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public Guid DeviceGuid { get; set; }
        [Required]
        public string DeviceName { get; set; } = "Device";
    }
}
