using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RentRepository : RepositoryBase<Rent>, IRentRepository
    {
        public RentRepository(RepositoryContext context) :
            base(context)
        {
        }


        public IEnumerable<Rent> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public IEnumerable<Rent> GetById(Guid id, bool trackChanges)
        {
            return FindByCondition(x => x.RentId.Equals(id), trackChanges).ToList();
        }
        public void CreateRent(Rent rent) => Create(rent);
        public void UpdateRent(Rent rent) => Update(rent);
        public void DeleteRent(Rent rent) => Delete(rent);
    }
}
