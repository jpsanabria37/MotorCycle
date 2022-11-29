using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
    {
        public PhoneRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Phone> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }
        public IEnumerable<Phone> GetById(Guid id, bool trackChanges)
        {
           return FindByCondition(x=>x.PhoneId.Equals(id),trackChanges).ToList();
        }

        public void CreatePhone(Phone phone) => Create(phone);
      
        public void UpdatePhone(Phone phone) => Update(phone);
      

        public void DeletePhone(Phone phone) => Delete(phone);
        

        
    }
}
