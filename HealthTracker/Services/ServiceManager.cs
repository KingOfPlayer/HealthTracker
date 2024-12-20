using HealthTracker.Services.Interfaces;

namespace HealthTracker.Services
{
    public class ServiceManager(IDeviceService deviceService, IDeviceDataService deviceDataService) : IServiceManager
    {
        private readonly IDeviceService deviceService = deviceService;
        private readonly IDeviceDataService deviceDataService = deviceDataService;

        public IDeviceService DeviceService => deviceService;
        public IDeviceDataService DeviceDataService => deviceDataService;
    }
}
