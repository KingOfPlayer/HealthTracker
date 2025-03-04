﻿using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;
using System;
using System.Linq.Expressions;

namespace HealthTracker.Repository
{
    public class DeviceRepository(RepositoryContext repositoryContext) : RepositoryBase(repositoryContext), IDeviceRepository
    {
        public async Task CreateDevice(Device device) => await Create<Device>(device);
        public async Task RemoveDevice(Device device) => await Remove<Device>(device);
        public async Task RemoveDevice(Guid guid)
        {
            Device device = Query<Device>(D => D.DeviceGuid == guid).FirstOrDefault()!;
            await Remove<Device>(device);
        }
        public async Task UpdateDevice(Device device) => await Update<Device>(device);
        public IQueryable<Device> GetDevices() => GetAll<Device>();
        public async Task<bool> DeviceIsExists(Guid guid)
        {
            return await Exists<Device>(D => D.DeviceGuid == guid);
        }

        public IQueryable<Device> GetDevice(Guid guid)
        {
            return Query<Device>(D => D.DeviceGuid == guid);
        }
    }
}
