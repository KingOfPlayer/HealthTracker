using HealthTracker.Services.Interfaces;

namespace HealthTracker.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IDeviceService deviceService;

        public ServiceManager(IDeviceService deviceService)
        {
            this.deviceService = deviceService;
        }

        public IDeviceService DeviceService => deviceService;
    }
}
