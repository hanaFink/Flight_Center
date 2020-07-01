using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center.Facade
{
    public class LoggedInAdministratorFacade : AnonymousUserFacade, ILoggedInAdministratorFacade
    {
        public void CreateNewAirline(LoginToken<Administrator> token, AirlineCompanie airline)
        {
            _airlineDao.Add(airline);
        }

        public void CreateNewCustomer(LoginToken<Administrator> token, Customer customer)
        {
            _customerDAO.Add(customer);
        }

        public void RemoveAirline(LoginToken<Administrator> token, AirlineCompanie airline)
        {
            _airlineDao.Remove(airline);
        }

        public void RemoveCustomer(LoginToken<Administrator> token, Customer customer)
        {
            _customerDAO.Remove(customer);
        }

        public void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompanie airline)
        {
            _airlineDao.Update(airline);
        }

        public void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer)
        {
            _customerDAO.Update(customer);
        }
    }
}

   