using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private readonly RepositoryContext _repositoryContext;

        private readonly Lazy<IAgencyRepository> _agency;
        private readonly Lazy<IClientRepository> _client;
        private readonly Lazy<ICityRepository> _city;
        private readonly Lazy<IGarageRepository> _garage;
        private readonly Lazy<IRentRepository> _rent;
        private readonly Lazy<IMotorcycleRepository> _Motorcycle;
        private readonly Lazy<IPhoneRepository> _Phone;

        public IAgencyRepository Agency => _agency.Value;
        public IClientRepository Client => _client.Value;
        public ICityRepository City => _city.Value;
        public IGarageRepository Garage => _garage.Value;
        public IRentRepository Rent => _rent.Value;

        public IMotorcycleRepository Motorcycle => _Motorcycle.Value;

        public IPhoneRepository Phone => _Phone.Value;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

            _agency = new Lazy<IAgencyRepository>(() => new AgencyRepository(repositoryContext));
            _client = new Lazy<IClientRepository>(() => new ClientRepository(repositoryContext));
            _city = new Lazy<ICityRepository>(() => new CityRepository(repositoryContext));
            _garage = new Lazy<IGarageRepository>(() => new GarageRepository(repositoryContext));
            _rent = new Lazy<IRentRepository>(() => new RentRepository(repositoryContext));
            _Motorcycle = new Lazy<IMotorcycleRepository> (() => new MotorcycleRepository(repositoryContext));
            _Phone = new Lazy<IPhoneRepository>(() => new PhoneRepository(repositoryContext));
        }

        
        public void Save() => _repositoryContext.SaveChanges();

    }
}
