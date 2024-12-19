using HealthTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HealthTracker.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IDeviceRepository deviceRepository;

        public RepositoryManager(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        public IDeviceRepository DeviceRepository => deviceRepository;

    }
}
