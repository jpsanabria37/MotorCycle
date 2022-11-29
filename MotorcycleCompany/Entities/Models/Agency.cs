using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("Agency")]
    public partial class Agency
    {
        public Agency()
        {
            Phones = new HashSet<Phone>();
            Rents = new HashSet<Rent>();
        }

        [Key]
        public Guid AgencyId { get; set; }
        [StringLength(60)]
        public string Address { get; set; } = null!;
        [StringLength(60)]
        public string Neighborhood { get; set; } = null!;
        [StringLength(60)]
        public string Location { get; set; } = null!;
        [StringLength(60)]
        public string Name { get; set; } = null!;

        [InverseProperty("Agency")]
        public virtual ICollection<Phone> Phones { get; set; }
        [InverseProperty("Agency")]
        public virtual ICollection<Rent> Rents { get; set; }

        public string GetPhones()
        {
            StringBuilder result = new StringBuilder("");
            foreach (Phone phone in Phones)
            {
                result.AppendFormat($"{phone.NumberPhone}, ");
            }

            return result.ToString();
        }
    }
}
