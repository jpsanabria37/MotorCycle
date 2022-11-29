using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IGarageRepository : IRepositoryBase<Garage>
    {
        IEnumerable<Garage> GetAll(bool trackChanges);
        IEnumerable<Garage> GetById(Guid id,  bool trackChanges);
        
        void CreateGarage(Garage garage);
        void UpdateGarage(Garage garage);
        void DeleteGarage(Garage garage);
    }
}
