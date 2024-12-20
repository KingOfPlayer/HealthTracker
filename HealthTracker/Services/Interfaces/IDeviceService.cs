﻿using HealthTracker.Entities.Dto.Device;

namespace HealthTracker.Services.Interfaces
{
    public interface IDeviceService
    {
        Task AddNewDevice(DeviceNameDto newDeviceDto);
        Task<DeviceDto?> GetDevice(DeviceGuidDto deviceGuidDto);
        Task<DeviceDetailsDto?> GetDeviceDetails(DeviceGuidDto deviceGuidDto);
        Task<IEnumerable<DeviceDto>> GetDeviceList();
        Task RemoveDevice(DeviceGuidDto deviceGuidDto);
    }
}