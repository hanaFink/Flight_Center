using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    interface ILogicService
    {
        bool TryAdministratorLogin(string userName, string password, out LoginToken<Administrator> token);
        bool TryAirlineLogin(string userName, string password, out LoginToken<Customers> token);

        bool TryCustomereLogin(string userName, string password, out LoginToken<AirlineCompanies> token);



    }
}
