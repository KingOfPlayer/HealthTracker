using HealthTracker.Entities.Models.Device;
using HealthTracker.Entities.Models.PushNotification;
using HealthTracker.Repository.Configs;
using Microsoft.EntityFrameworkCore;

namespace HealthTracker.Repository
{
    public class RepositoryContext(DbContextOptions<RepositoryContext> options) : DbContext(options)
    {
#pragma warning disable IDE0051 // Remove unused private members
        private DbSet<PushNotificationKey> PushNotificationKeys { get; set; }
        private DbSet<Device> Devices { get; set; }
        private DbSet<DeviceData> DeviceDatas { get; set; }
#pragma warning restore IDE0051 // Remove unused private members

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DeviceConfig());
        }
    }
}
