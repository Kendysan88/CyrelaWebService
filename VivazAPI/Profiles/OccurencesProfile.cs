using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;
namespace VivazAPI.Profiles
{
    public class OccurrencesProfile : Profile
    {
        public OccurrencesProfile()
        {
            CreateMap<Occurrence, OccurrenceReadDto>();
            CreateMap<Occurrence, OccurrenceWithDetailsReadDto>();
            CreateMap<OccurrenceCreateDto, Occurrence>();
            CreateMap<OccurrenceUpdateDto, Occurrence>();
            CreateMap<Occurrence, OccurrenceUpdateDto>();
        }
    }
}
