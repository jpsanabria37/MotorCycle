using Contracts;
using Entities.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CityService : ICityService
    {

        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;

        public CityService(IRepositoryWrapper repository, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
        }

        public void CreateCity(City city)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAllCities(bool trackChanges)
        {
            try
            {

                return _repository.City.GetAll(trackChanges);
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }
    }
}
