using HealthTracker.Entities.Models.Device;
using HealthTracker.Entities.Models.PushNotification;
using HealthTracker.Repository.Configs;
using Microsoft.EntityFrameworkCore;

namespace HealthTracker.Repository
{
    public class RepositoryContext : DbContext
    {
        DbSet<PushNotificationKey> PushNotificationKeys { get; set; }
        DbSet<Device> Devices { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DeviceConfig());
        }
    }
}
