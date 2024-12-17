using HealthTracker.Entities.Models.Device;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTracker.Repository.Configs
{
    public class DeviceConfig : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.Property(D => D.DeviceGuid).HasDefaultValueSql("NEWID()");
        }
    }
}
