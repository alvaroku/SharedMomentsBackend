using AutoMapper;
using SharedMomentsBackend.App.Models.DTOs.Moment;
using SharedMomentsBackend.App.Models.Entities;

namespace SharedMomentsBackend.App.Services.MappingProfiles
{
    public class MomentProfile : Profile
    {
        public MomentProfile()
        {
            CreateMap<Moment, MomentRequest>().ReverseMap();
            
        }
    }
}
