using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
   public class AgencyDto
    {
        public string Address { get; set; } = null!;

        public string Neighborhood { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Phone { get; set; }
    }
}
