using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("City")]
    public partial class City
    {
        public City()
        {
            Garages = new HashSet<Garage>();
        }

        [Key]
        public Guid CityId { get; set; }
        [StringLength(60)]
        public string? Name { get; set; }
        [StringLength(60)]
        public string? Department { get; set; }
        public int? Inhabitants { get; set; }

        [InverseProperty("City")]
        public virtual ICollection<Garage> Garages { get; set; }
    }
}
