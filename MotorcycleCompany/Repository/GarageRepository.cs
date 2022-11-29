using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GarageRepository : RepositoryBase<Garage>, IGarageRepository
    {
        public GarageRepository(RepositoryContext context) : 
            base(context)
        {
        }
        public IEnumerable<Garage> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public IEnumerable<Garage> GetById(Guid id, bool trackChanges)
        {
            return FindByCondition(x => x.GarageId.Equals(id), trackChanges).ToList();
        }

        public void CreateGarage(Garage garage) => Create(garage);
        public void DeleteGarage(Garage garage) => Delete(garage);
        public void UpdateGarage(Garage garage) => Update(garage);
    }
}
