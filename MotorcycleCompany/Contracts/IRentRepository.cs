using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRentRepository : IRepositoryBase<Rent>
    {
        IEnumerable<Rent> GetAll(bool trackChanges);
        IEnumerable<Rent> GetById(Guid id, bool trackChanges);
        void CreateRent(Rent rent);
        void UpdateRent(Rent rent);
        void DeleteRent(Rent rent);
    }
}
