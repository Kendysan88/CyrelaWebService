using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Profiles
{
    public class AddressStatesProfile : Profile
    {
        public AddressStatesProfile()
        {
            CreateMap<AddressState, AddressStateReadDto>();
        }
    }
}
