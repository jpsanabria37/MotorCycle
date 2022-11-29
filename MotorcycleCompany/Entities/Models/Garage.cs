using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("Garage")]
    public partial class Garage
    {
        public Garage()
        {
            Motorcycles = new HashSet<Motorcycle>();
        }

        [Key]
        public Guid GarageId { get; set; }
        [Key]
        [StringLength(60)]
        public string Address { get; set; } = null!;
        [StringLength(60)]
        public string Name { get; set; } = null!;
        public Guid CityId { get; set; }

        [ForeignKey("CityId")]
        [InverseProperty("Garages")]
        public virtual City City { get; set; } = null!;
        [InverseProperty("Garage")]
        public virtual ICollection<Motorcycle> Motorcycles { get; set; }
    }
}
