﻿using AutoMapper;
using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;

namespace HealthTracker.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Device
            CreateMap<DeviceDto, Device>().ReverseMap();
            CreateMap<DeviceNameDto, Device>().ReverseMap();
            CreateMap<DeviceGuidDto, Device>().ReverseMap();

            //Device Data
            CreateMap<NewDeviceDataDto, DeviceData>().ReverseMap();
        }
    }
}
