using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MotorcycleRepository : RepositoryBase<Motorcycle>, IMotorcycleRepository
    {
        public MotorcycleRepository(RepositoryContext context) : base(context)
        {
        }
        public IEnumerable<Motorcycle> GetAll(bool trackChanges)
        {
            return  FindAll(trackChanges).ToList();
        }
        public IEnumerable<Motorcycle> GetById(Guid id, bool trackChanges)
        {
            return FindByCondition(x=>x.MotorcycleId.Equals(id),trackChanges).ToList() ;
        }

        public void CreateMotorcycle(Motorcycle motorcycle) => Create(motorcycle);
      

        
        public void UpdateMotorcycle(Motorcycle motorcycle) => Update(motorcycle);
        

        public void DeleteMotorcycle(Motorcycle motorcycle) => Delete(motorcycle);

    }
}
