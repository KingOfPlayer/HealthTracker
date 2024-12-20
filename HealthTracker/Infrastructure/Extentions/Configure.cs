using HealthTracker.Infrastructure.Mapper;
using HealthTracker.Repository;
using HealthTracker.Repository.Interfaces;
using HealthTracker.Services;
using HealthTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthTracker.Infrastructure.Extentions
{
    static class Configure
    {
        public static void ConfigureRepositories(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<IRepositoryManager, RepositoryManager>();
            serviceDescriptors.AddScoped<IDeviceRepository, DeviceRepository>();
        }
        public static void ConfigureServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddScoped<IServiceManager, ServiceManager>();
            serviceDescriptors.AddScoped<IDeviceService, DeviceService>();

            serviceDescriptors.AddAutoMapper(typeof(MappingProfile));
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
