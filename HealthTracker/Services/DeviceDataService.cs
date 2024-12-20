using AutoMapper;
using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;
using HealthTracker.Services.Interfaces;

namespace HealthTracker.Services
{
    public class DeviceDataService(IRepositoryManager repositoryManager, IMapper mapper) : IDeviceDataService
    {
        private readonly IRepositoryManager repositoryManager = repositoryManager;
        private readonly IMapper mapper = mapper;

        public async Task CreateDeviceData(DeviceDataDto deviceDataDto, DeviceDetailsDto deviceDetailsDto)
        {
            DeviceData deviceData = mapper.Map<DeviceData>(deviceDataDto);
            deviceData.DeviceId = deviceDetailsDto.DeviceId;
            await repositoryManager.DeviceDataRepository.CreateDeviceData(deviceData);
        }
    }
}
