using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Profiles
{
    public class BrandsProfile : Profile
    {
        public BrandsProfile()
        {
            CreateMap<Brand, BrandReadDto>();
        }
    }
}
