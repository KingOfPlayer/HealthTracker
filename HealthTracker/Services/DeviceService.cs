using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;
using HealthTracker.Services.Interfaces;

namespace HealthTracker.Services
{
    public class DeviceService : IDeviceService
    {
        private IRepositoryManager repositoryManager;

        public DeviceService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public void AddNewDevice(Device newDevice)
        {
            repositoryManager.DeviceRepository.CreateDevice(newDevice);
        }

        public List<Device> GetDeviceList()
        {
            return repositoryManager.DeviceRepository.GetDevices().ToList();
        }
    }
}
