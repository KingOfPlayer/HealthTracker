using HealthTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HealthTracker.Repository
{
    public class RepositoryManager(IDeviceRepository deviceRepository, IDeviceDataRepository deviceDataRepository) : IRepositoryManager
    {
        private readonly IDeviceRepository deviceRepository = deviceRepository;
        private readonly IDeviceDataRepository deviceDataRepository = deviceDataRepository;

        public IDeviceRepository DeviceRepository => deviceRepository;
        public IDeviceDataRepository DeviceDataRepository => deviceDataRepository;

    }
}
