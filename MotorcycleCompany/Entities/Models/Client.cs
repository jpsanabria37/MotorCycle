using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("Client")]
    public partial class Client
    {
        public Client()
        {
            Rents = new HashSet<Rent>();
        }

        [Key]
        public Guid ClientId { get; set; }
        [StringLength(60)]
        public string TypeId { get; set; } = null!;
        [StringLength(20)]
        public string Number { get; set; } = null!;
        [StringLength(60)]
        public string FistName { get; set; } = null!;
        [StringLength(60)]
        public string LastName { get; set; } = null!;
        [StringLength(60)]
        public string Address { get; set; } = null!;
        [StringLength(20)]
        public string Phone { get; set; } = null!;
        [Column("E-Mail")]
        [StringLength(60)]
        public string E_Mail { get; set; } = null!;

        [InverseProperty("Client")]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
