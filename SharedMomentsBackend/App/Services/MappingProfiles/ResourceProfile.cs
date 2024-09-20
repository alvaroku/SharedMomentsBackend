using AutoMapper;
using SharedMomentsBackend.App.Models.DTOs.Album;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.DTOs.Resource;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Services.MappingProfiles
{
    public class ResourceProfile : Profile
    {
        public ResourceProfile()
        {
            CreateMap<Resource, ResourceResponse>().ReverseMap();
            
        }
    }
}
