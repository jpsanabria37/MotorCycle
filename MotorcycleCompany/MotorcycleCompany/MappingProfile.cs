using AutoMapper;
using Entities.Models;
using Shared.DTO;

namespace MotorcycleCompany
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           CreateMap<Agency, AgencyDto>()
          .ForMember(dest =>
          dest.Phone,
          opt => opt.MapFrom(src => src.GetPhones()));
        }
    }
}
