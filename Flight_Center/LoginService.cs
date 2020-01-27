using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    class LoginService : ILogicService
    {
        private IAirlineDAO _airlineDAO;
        private ICustomerDAO _customerADO;

        public bool TryAdministratorLogin(string userName, string password, out LoginToken<Administrator> token)
        {
            throw new NotImplementedException();
        }

            public bool TryAirlineLogin(string userName, string password, out LoginToken<Customers> token)
        {
            throw new NotImplementedException();
        }

        public bool TryCustomereLogin(string userName, string password, out LoginToken<AirlineCompanies> token)
        {
            throw new NotImplementedException();
        }
    }
}
