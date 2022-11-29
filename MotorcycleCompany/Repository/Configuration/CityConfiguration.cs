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
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City
                {
                    CityId = Guid.NewGuid(),
                    Name = "Bogota",
                    Department = "Bogota",
                    Inhabitants = 23

                },
                new City
                {
                    CityId = Guid.NewGuid(),
                    Name = "Medellin",
                    Department = "Tusi",
                    Inhabitants = 21

                }
                

                );
            
        }
    }
}
