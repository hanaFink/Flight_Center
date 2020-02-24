using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center.Facade
{
    interface ILoggedInAdministratorFacade
    {
        void CreateNewAirline(LoginToken<Administrator>token,AirlineCompanie airline);
        void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompanie airline);
        void RemoveAirline(LoginToken<Administrator>token, AirlineCompanie airline);
        void CreateNewCustomer(LoginToken<Administrator> token, Customer customer);
        void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer);
        void RemoveCustomer(LoginToken<Administrator> token, Customer customer);
    }
}
