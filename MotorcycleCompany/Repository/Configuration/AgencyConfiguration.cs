using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.HasData(
                new Agency
                {
                    AgencyId = Guid.NewGuid(),
                    Name = "Agencia01",
                    Address = "Calle del recuerdo",
                    Neighborhood = "Santa Barbara",
                    Location = "Usaquen"

                },
                new Agency
                {
                    AgencyId = Guid.NewGuid(),
                    Name = "Agencia02",
                    Address = "Calle de la soledad",
                    Neighborhood = "Santa Ana",
                    Location = "Usaquen"
                }
            );
        }
    }
}
