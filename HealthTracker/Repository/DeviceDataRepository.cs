using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;

namespace HealthTracker.Repository
{
    public class DeviceDataRepository(RepositoryContext repositoryContext) : RepositoryBase(repositoryContext), IDeviceDataRepository
    {
        public async Task CreateDeviceData(DeviceData DeviceData) => await Create<DeviceData>(DeviceData);
        public async Task RemoveDeviceData(DeviceData DeviceData) => await Remove<DeviceData>(DeviceData);
        public async Task UpdateDeviceData(DeviceData DeviceData) => await Update<DeviceData>(DeviceData);
        public IQueryable<DeviceData> GetAllDeviceDatas() => GetAll<DeviceData>();
        public IQueryable<DeviceData> GetDeviceDatas(Guid guid)
        {
            return Query<DeviceData>(D => D.DeviceGuid == guid);
        }
    }
}
