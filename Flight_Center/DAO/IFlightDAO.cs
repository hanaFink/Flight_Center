using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public interface IFlightDAO:IBasicDB<Flight>
    {
        Dictionary<Flight, int> GetAllFlithtsVacancy();
        Flight Get(int id);
        IList<Flight> GetFlightsByOriginCountry(int countryCode);
        IList<Flight> GetFlightsByDistinationCountry(int countryCode);

        IList<Flight> GetFlightsByDepatrureDate(DateTime depatrureDate);
        IList<Flight> GetFlightsByLandingDate (DateTime landingDate);
        IList<Flight> GetFlightsByCustomer(Customer customer);
        IList<Flight> GetFlightsByAirlineId(Int64 id);
        IList<Flight> GetFlightsByOldDate();
        void AddToOld_Flights(IList<Flight> flightsToAdd);
        void RemoveListOfFlights(IList<Flight> flightToRemove);



    }
}
