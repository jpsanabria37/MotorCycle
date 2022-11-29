using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData(
                new Client
                {
                    ClientId = Guid.NewGuid(),
                    TypeId = "CC",
                    Number = "79802910",
                    FistName = "German Gilberto",
                    LastName= "Alarcon R",
                    Address= "La calle del ocio",
                    Phone = "3153666036",
                    E_Mail = "german.alarcon@misena.edu.co"
                },
                new Client
                {
                    ClientId = Guid.NewGuid(),
                    TypeId = "CC",
                    Number = "79802911",
                    FistName = "Ana Yaqueline",
                    LastName = "Chavarro",
                    Address = "La calle de la Melancolia",
                    Phone = "3153666037",
                    E_Mail = "ana.yaqueline@misena.edu.co"
                }
            );
        }
    }
}
