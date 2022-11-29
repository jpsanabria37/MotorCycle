using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AgencyRepository :RepositoryBase<Agency>, IAgencyRepository
    {
        public AgencyRepository(RepositoryContext context) 
            : base(context)
        {
        }
        public IEnumerable<Agency> GetAll(bool trackChanges)
        {
            /*https://riptutorial.com/repository-pattern/learn/100007/create-generic-repository */
            /* https://www.oscarblancarteblog.com/2018/11/30/data-transfer-object-dto-patron-diseno/ */
            return FindAll(trackChanges).Include("Phones").Include("Rents").ToList();
     
        }

        public IEnumerable<Agency> GetById(Guid id, bool trackChanges)
        {

            return FindByCondition(x => x.AgencyId.Equals(id), trackChanges).ToList();
        }

        public void CreateAgency(Agency agency) => Create(agency);

        public void UpdateAgency(Agency agency) => Update(agency);

        public void DeleteAgency(Agency agency) => Delete(agency);

    }
}
