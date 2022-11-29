using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IMotorcycleService
    {
        IEnumerable<Motorcycle> GetAllMotorcycles(bool trackChanges);
        void CreateMoto(Motorcycle moto);
    }
}
