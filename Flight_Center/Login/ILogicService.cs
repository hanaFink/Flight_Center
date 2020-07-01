using Flight_Center.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    interface ILogicService
    {
        void TryAdministratorLogin(string userName, string password,out LoggedInAdministratorFacade loggedInAdministratorFacade, out LoginToken<Administrator> token);

        void TryAirlineLogin(string userName, string password,out LoggedInAirlineFacade loggedInAirlineFacade,  out LoginToken<AirlineCompanie> token);

        void TryCustomereLogin(string userName, string password,out LoggedInCustomerFacade loggedInCustomerFacade, out LoginToken<Customer> token);



    }
}
