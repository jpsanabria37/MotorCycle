using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        IEnumerable<Client> GetAll(bool trackChanges);
        IEnumerable<Client> GetById(Guid id, bool trackChanges);
        void CreateClient(Client client);
        void UpdateClient(Client client);
        //void UpdateRange(List<T> entity);
        void DeleteClient(Client client);
    }
}
