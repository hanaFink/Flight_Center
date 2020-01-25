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
        private ICustomer _customerADO;

        public bool TryAdministratorLogin(string user_name, string password, out LoginToken<Administrator> token)
        {
            if (true)
            {
                token =  ;
                return true;
            }
                    }

        public bool TryAirlineLogin(string user_name, string password, out LoginToken<Customers> token)
        {
            throw new NotImplementedException();
        }

        public bool TryCustomereLogin(string user_name, string password, out LoginToken<AirlineCompanies> token)
        {
            throw new NotImplementedException();
        }
    }
}
