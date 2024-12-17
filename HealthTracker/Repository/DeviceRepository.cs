using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;
using System.Linq.Expressions;

namespace HealthTracker.Repository
{
    public class DeviceRepository : RepositoryBase, IDeviceRepository
    {
        public DeviceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateDevice(Device device) => Create<Device>(device);
        public void RemoveDevice(Device device) => Remove<Device>(device);
        public void UpdateDevice(Device device) => Update<Device>(device);
        public IQueryable<Device> GetDevices() => GetAll<Device>();
        public IQueryable<Device> GetDevice(Guid guid)
        {
            return Query<Device>(D => D.DeviceGuid == guid);
        }

    }
}
