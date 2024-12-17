using HealthTracker.Repository;
using HealthTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthTracker.Extentions
{
    static class Configure
    {
        public static void ConfigureRepository(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<IRepositoryManager, RepositoryManager>();
            serviceDescriptors.AddScoped<IDeviceRepository, DeviceRepository>();

        }

        public static void ConfigureSqlConnection(this IServiceCollection serviceDescriptors, WebApplicationBuilder builder)
        {
            serviceDescriptors.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("mssqlconnection"), b => b.MigrationsAssembly("HealthTracker"));
                options.EnableSensitiveDataLogging(true);
            }, ServiceLifetime.Scoped);
        }
    }
}
