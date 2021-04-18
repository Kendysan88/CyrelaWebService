using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Properties
{
    public class BuildingsProfile : Profile
    {
        public BuildingsProfile()
        {
            CreateMap<Building, BuildingReadDto>();
            CreateMap<Building, BuildingWithDetailsReadDto>();
            CreateMap<BuildingCreateDto, Building>();
            CreateMap<BuildingUpdateDto, Building>();
            CreateMap<Building, BuildingUpdateDto>();
        }
    }
}
