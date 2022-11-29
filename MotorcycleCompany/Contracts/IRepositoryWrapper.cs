using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IAgencyRepository Agency { get; }
        IClientRepository Client { get; }
        ICityRepository City { get; }
        IGarageRepository Garage { get; }
        IRentRepository Rent { get; }
        IMotorcycleRepository Motorcycle { get; }
        IPhoneRepository Phone { get; }

        void Save();
    }
}
