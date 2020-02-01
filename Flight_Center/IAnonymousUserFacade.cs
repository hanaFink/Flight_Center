using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    interface IAnonymousUserFacade
    {
        IList<Flights> GetAllFlights();
        IList<AirlineCompanie> GetAllAirlineCompanies();
        Dictionary<Flights, int> GetAllFlightsVacancy();
        Flights GetFlightById(int id);
        IList<Flights> GetFlightsByOriginCountry(int countryCode);
        IList<Flights> GetFlightsByDestinationCountry(int countryCode);
        IList<Flights> GetFlightsByDepartureDate(DateTime departureDate);
        IList<Flights> GetFlightsByLandingDate(DateTime landingDate);


    }
}
