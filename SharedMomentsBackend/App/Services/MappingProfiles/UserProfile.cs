using AutoMapper;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Services.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, LoginResponse>().ReverseMap();
            CreateMap<User, UserRequest>().ReverseMap();
            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}
