using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
     public abstract class FacadeBase
    {
        protected IAirlineDAO _airlineDao;
        protected ICountryDAO _countryDao;
        protected ICustomerDAO _customerDAO;
        protected IFlightDAO _flightDAO;
        protected ITicketDAO _ticketDAO;

        public FacadeBase()
        {
            _airlineDao = new AirlineDAOMSSQL();
            _countryDao = new CountryDAOMSSQL();
            _customerDAO = new CustomerDAOMSSQL();
            _flightDAO = new FlightDAOMSSQL();
            _ticketDAO = new TicketDaoMSSQL();
    }


    }
}
