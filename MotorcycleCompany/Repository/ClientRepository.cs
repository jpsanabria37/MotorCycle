using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext context) 
            : base(context)
        {
        }

        public IEnumerable<Client> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public IEnumerable<Client> GetById(Guid id, bool trackChanges)
        {
            return FindByCondition(x => x.ClientId.Equals(id), trackChanges).ToList();
        }

        public void CreateClient(Client client) => Create(client);
        public void DeleteClient(Client client) => Delete(client);
        public void UpdateClient(Client client) => Update(client);
    }
}
