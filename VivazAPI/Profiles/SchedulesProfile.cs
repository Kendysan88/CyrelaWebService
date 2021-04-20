using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Profiles
{
    public class SchedulesProfile : Profile
    {
        public SchedulesProfile()
        {
            CreateMap<Schedule, ScheduleReadDto>();
            CreateMap<Schedule, ScheduleWithDetailsReadDto>();
            CreateMap<ScheduleCreateDto, Schedule>();
            CreateMap<ScheduleUpdateDto, Schedule>();
            CreateMap<Schedule, ScheduleReadDto>();
        }
    }
}
