using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("Rent")]
    public partial class Rent
    {
        [Key]
        public Guid RentId { get; set; }
        [Key]
        [StringLength(10)]
        public string MotorcycleId { get; set; } = null!;
        [Key]
        public Guid ClientId { get; set; }
        [Key]
        public Guid AgencyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReservationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RentalDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }
        public decimal Price { get; set; }
        [StringLength(2)]
        public string Paid { get; set; } = null!;

        [ForeignKey("AgencyId")]
        [InverseProperty("Rents")]
        public virtual Agency Agency { get; set; } = null!;
        [ForeignKey("ClientId")]
        [InverseProperty("Rents")]
        public virtual Client Client { get; set; } = null!;
        [ForeignKey("MotorcycleId")]
        [InverseProperty("Rents")]
        public virtual Motorcycle Motorcycle { get; set; } = null!;
    }
}
