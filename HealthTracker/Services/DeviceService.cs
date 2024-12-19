using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;
using HealthTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthTracker.Services
{
    public class DeviceService : IDeviceService
    {
        private IRepositoryManager repositoryManager;

        public DeviceService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public async Task AddNewDevice(Device newDevice)
        {
            await repositoryManager.DeviceRepository.CreateDevice(newDevice);
        }

        public async Task<List<Device>> GetDeviceList()
        {
            return await repositoryManager.DeviceRepository.GetDevices().ToListAsync();
        }

        public async Task RemoveDevice(Guid guid)
        {
            await repositoryManager.DeviceRepository.RemoveDevice(guid);
        }
    }
}
