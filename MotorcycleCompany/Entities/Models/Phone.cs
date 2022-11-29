using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("Phone")]
    public partial class Phone
    {
        [Key]
        public Guid AgencyId { get; set; }
        [Key]
        public Guid PhoneId { get; set; }

        public string NumberPhone { get; set; }

        [ForeignKey("AgencyId")]
        [InverseProperty("Phones")]
        public virtual Agency? Agency { get; set; } = null!;
    }
}
