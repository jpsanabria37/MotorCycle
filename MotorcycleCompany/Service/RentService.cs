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
    public sealed class RentService : IRentService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;

        public RentService(IRepositoryWrapper repository, ILoggerManager loggerManager)
        {
            _repository = repository;
            _loggerManager = loggerManager;
        }

        public void createRent(Rent rent) => _repository.Rent.CreateRent(rent);

        public IEnumerable<Rent> GetAllRents(bool trackChanges)
        {
            try
            {

                return _repository.Rent.GetAll(trackChanges);
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Mas dañino que el azucar: {ex.Message}");
                throw;
            }
        }
    }
}
