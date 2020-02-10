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
        Flight GetFlightsById(int id);
        IList<Flight> GetFlightsByOriginCountry(int countryCode);
        IList<Flight> GetFlightsByDistinationCountry(int countryCode);

        IList<Flight> GetFlightsByDepatrureDate(DateTime depatrureDate);
        IList<Flight> GetFlightsByLandingDate (DateTime landingDate);
        IList<Flight> GetFlightsByCustomer(Customers customer);

    }
}
