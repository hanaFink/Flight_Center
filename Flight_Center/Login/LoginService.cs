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
            if (userName == "admin" & password == "9999")
                return true;
            throw new 
        }

            public bool TryAirlineLogin(string userName, string password, out LoginToken<Customer> token)
        {
            throw new NotImplementedException();
        }

        public bool TryCustomereLogin(string userName, string password, out LoginToken<AirlineCompanie> token)
        {
            throw new NotImplementedException();
        }
    }
}
