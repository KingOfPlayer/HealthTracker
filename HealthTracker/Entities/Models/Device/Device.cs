using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Models.Device
{
    public class Device
    {
        [Key]
        public Guid DeviceGuid { get; set; }

        public required string DeviceName { get; set; } = "Device";
    }
}
