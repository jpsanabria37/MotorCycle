using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IAgencyService AgencyService {get;}
        ICityService CityService { get; }
        IClientService ClientService { get; }
        IGarageService GarageService { get; }
        IRentService RentService { get; }
        IMotorcycleService MotorcycleService { get; }
        IPhoneService PhoneService { get; }

        void Save();

    }
}
