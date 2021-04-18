using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Profiles
{
    public class ActivityTypesProfile : Profile
    {
        public ActivityTypesProfile()
        {
            CreateMap<ActivityType, ActivityTypeReadDto>();
        }
    }
}
