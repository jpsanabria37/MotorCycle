using AutoMapper;
using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Profiles
{
    public class AgencyProfile : Profile

    {
        public AgencyProfile()
        {
            CreateMap<Agency, AgencyDto>()
            .ForMember(dest =>
            dest.Phone,
            opt => opt.MapFrom("gjfkgfljkdfjklg")); 
        }
    }
}
