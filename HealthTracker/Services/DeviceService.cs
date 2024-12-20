using AutoMapper;
using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;
using HealthTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthTracker.Services
{
    public class DeviceService(IRepositoryManager repositoryManager, IMapper mapper) : IDeviceService
    {
        private readonly IRepositoryManager repositoryManager = repositoryManager;
        private readonly IMapper mapper = mapper;

        public async Task AddNewDevice(DeviceNameDto newDeviceDto)
        {
            Device device = mapper.Map<Device>(newDeviceDto);
            await repositoryManager.DeviceRepository.CreateDevice(device);
        }

        public async Task<IEnumerable<DeviceDto>> GetDeviceList()
        {
            return await repositoryManager.DeviceRepository.GetDevices().Select(x => new DeviceDto(x.DeviceGuid, x.DeviceName)).ToListAsync();
        }

        public async Task RemoveDevice(DeviceGuidDto deviceGuidDto)
        {
            await repositoryManager.DeviceRepository.RemoveDevice(deviceGuidDto.DeviceGuid);
        }

        public async Task<DeviceDetailsDto?> GetDeviceDetails(DeviceGuidDto deviceGuidDto)
        {
            return await repositoryManager.DeviceRepository.GetDevice(deviceGuidDto.DeviceGuid).Select(x => new DeviceDetailsDto(x.DeviceId,x.DeviceGuid, x.DeviceName)).FirstOrDefaultAsync();
        }
    }
}
