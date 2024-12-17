using System.ComponentModel.DataAnnotations;

namespace HealthTracker.Entities.Models.PushNotification
{
    public class PushNotificationKey
    {
        [Key]
        public int PushNotificationKeyId { get; set; }
        public required string Endpoint { get; set; }
        public required string P256DH { get; set; }
        public required string AuthKey { get; set; }
    }
}
