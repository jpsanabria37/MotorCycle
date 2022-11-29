using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public  interface IPhoneRepository :IRepositoryBase<Phone>
    {
        IEnumerable<Phone> GetAll(bool trackChanges);
        IEnumerable<Phone> GetById(Guid id, bool trackChanges);
        void CreatePhone(Phone phone);
        void UpdatePhone(Phone phone);
        //void UpdateRange(List<T> entity);
        void DeletePhone(Phone phone);

    }
}
