using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Profiles
{
    public class OccurencesProfile : Profile
    {
        public OccurencesProfile()
        {
            CreateMap<Occurence, OccurenceReadDto>();
            CreateMap<OccurenceCreateDto, Occurence>();
            CreateMap<OccurenceUpdateDto, Occurence>();
            CreateMap<Occurence, OccurenceUpdateDto>();
        }
    }
}
