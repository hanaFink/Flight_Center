using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    abstract class FacadeBase
    {
        protected IAirlineDAO _airlineDao;
        protected ICountryDAO _countryDao;
        protected ICustomerDAO _customerDAO;
        protected IFlightDAO _flightDAO;
        protected ITicketDAO _ticketDAO;

    }
}
