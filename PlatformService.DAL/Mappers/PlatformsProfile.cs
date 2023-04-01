using AutoMapper;
using PlatformService.DAL.Dtos;
using PlatformService.Domain.Models;

namespace PlatformService.DAL.Mappers
{
    public class PlatformsProfile: Profile
    {
        public PlatformsProfile()
        {
            //source -> target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<CreatePlatformDto, Platform>();
        }


    }
}
