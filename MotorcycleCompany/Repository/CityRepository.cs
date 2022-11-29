using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(RepositoryContext context) 
            : base(context)
        {
        }


        public IEnumerable<City> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public IEnumerable<City> GetById(Guid id, bool trackChanges)
        {
            return FindByCondition(x => x.CityId.Equals(id), trackChanges).ToList();
        }

        public void CreateCity(City city) => Create(city);

        public void UpdateCity(City city) => Update(city);


        public void DeleteCity(City city) => Delete(city);

    }
}
