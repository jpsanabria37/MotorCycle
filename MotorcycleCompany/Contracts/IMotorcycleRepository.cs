using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMotorcycleRepository : IRepositoryBase<Motorcycle>
    {
        IEnumerable<Motorcycle> GetAll(bool trackChanges);
        IEnumerable<Motorcycle> GetById(Guid id, bool trackChanges);
        void CreateMotorcycle(Motorcycle motorcycle);
        void UpdateMotorcycle(Motorcycle motorcycle);
        //void UpdateRange(List<T> entity);
        void DeleteMotorcycle(Motorcycle motorcycle);

    }
}
