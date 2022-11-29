using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("Motorcycle")]
    public partial class Motorcycle
    {
        public Motorcycle()
        {
            Rents = new HashSet<Rent>();
        }

        [Key]
        [StringLength(10)]
        public string MotorcycleId { get; set; } = null!;
        [StringLength(30)]
        public string Chassis { get; set; } = null!;
        [StringLength(30)]
        public string Color { get; set; } = null!;
        [StringLength(50)]
        public string Make { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime DateOfEntry { get; set; }
        public Guid GarageId { get; set; }
        [StringLength(60)]
        public string Address { get; set; } = null!;

        [ForeignKey("GarageId,Address")]
        [InverseProperty("Motorcycles")]
        public virtual Garage Garage { get; set; } = null!;
        [InverseProperty("Motorcycle")]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
