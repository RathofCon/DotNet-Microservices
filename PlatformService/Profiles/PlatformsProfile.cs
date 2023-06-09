using AutoMapper;
using PlatformService.Dtos;

namespace PlatformService.Profiles
{

    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // source -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();

        }
    }
}