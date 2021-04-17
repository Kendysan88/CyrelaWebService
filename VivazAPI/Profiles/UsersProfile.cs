using AutoMapper;
using VivazAPI.Dtos;
using VivazAPI.Models;

namespace VivazAPI.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserReadDto>();
        }
    }
}
