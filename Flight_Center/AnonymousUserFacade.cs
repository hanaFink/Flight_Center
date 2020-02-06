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

        public IList<Flights> GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Flights, int> GetAllFlightsVacancy()
        {
            throw new NotImplementedException();
        }

        public Flights GetFlightById(int id)
        {
            return _flightDAO.GetFlightsById(id);
        }

        public IList<Flights> GetFlightsByDepartureDate(DateTime departureDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByDestinationCountry(int countryCode)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByLandingDate(DateTime landingDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByOriginCountry(int countryCode)
        {
            throw new NotImplementedException();
        }
    }

 
    
}
