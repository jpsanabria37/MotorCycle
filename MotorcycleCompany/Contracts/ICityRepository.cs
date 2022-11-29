using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICityRepository : IRepositoryBase<City>
    {
        IEnumerable<City> GetAll(bool trackChanges);
        IEnumerable<City> GetById(Guid id, bool trackChanges);
        void CreateCity(City city);
        void UpdateCity(City city);
        //void UpdateRange(List<T> entity);
        void DeleteCity(City city);

    }
}
