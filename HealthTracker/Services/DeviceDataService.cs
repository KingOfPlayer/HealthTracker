using AutoMapper;
using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;
using HealthTracker.Repository.Interfaces;
using HealthTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthTracker.Services
{
    public class DeviceDataService(IRepositoryManager repositoryManager, IMapper mapper) : IDeviceDataService
    {
        private readonly IRepositoryManager repositoryManager = repositoryManager;
        private readonly IMapper mapper = mapper;

        public async Task CreateDeviceData(NewDeviceDataDto deviceDataDto, DeviceDetailsDto deviceDetailsDto)
        {
            DeviceData deviceData = mapper.Map<DeviceData>(deviceDataDto);
            deviceData.DeviceId = deviceDetailsDto.DeviceId;
            await repositoryManager.DeviceDataRepository.CreateDeviceData(deviceData);
        }

        public async Task<IEnumerable<DeviceDataDto>> GetDeviceDatas(DeviceDetailsDto deviceDetailsDto)
        {
            return await repositoryManager.DeviceDataRepository.GetDeviceDatas(deviceDetailsDto.DeviceId).Select(x => new DeviceDataDto(x.dateTime,x.Spo2,x.Bpm,x.Temp,x.Humidity)).ToListAsync();
        }
    }
}
