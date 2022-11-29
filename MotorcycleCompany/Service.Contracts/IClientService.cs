using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IClientService
    {
        IEnumerable<Client> GetAllClients(bool trackChanges);

        void CreateClient(Client client);
    }
}
