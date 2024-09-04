using AutoMapper;
using SharedMomentsBackend.App.Models.DTOs.Album;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Services.MappingProfiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<Album, AlbumRequest>().ReverseMap();
            
        }
    }
}
