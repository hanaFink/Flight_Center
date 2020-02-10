using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    class AnonymousUserFacade : FacadeBase, IAnonymousUserFacade//here we will check all errors
    {
        public IList<AirlineCompanie> GetAllAirlineCompanies()
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Flight, int> GetAllFlightsVacancy()
        {
            throw new NotImplementedException();
        }

        public Flight GetFlightById(int id)
        {
            return _flightDAO.GetFlightsById(id);
        }

        public IList<Flight> GetFlightsByDepartureDate(DateTime departureDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByDestinationCountry(int countryCode)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByLandingDate(DateTime landingDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByOriginCountry(int countryCode)
        {
            throw new NotImplementedException();
        }
    }

 
    
}
