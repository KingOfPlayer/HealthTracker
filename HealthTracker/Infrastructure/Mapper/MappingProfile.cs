using AutoMapper;

using HealthTracker.Entities.Dto.Device;
using HealthTracker.Entities.Models.Device;

namespace MyDentalHealth.Extentions.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			//New Device
			CreateMap<NewDeviceDto, Device>();
		}
	}
}
