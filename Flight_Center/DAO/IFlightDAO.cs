using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public interface IFlightDAO:IBasicDB<Flights>
    {
        Dictionary<Flights, int> GetAllFlithtsVacancy();
        Flights GetFlightsById(int id);
        IList<Flights> GetFlightsByOriginCountry(int countryCode);
        IList<Flights> GetFlightsByDistinationCountry(int countryCode);

        IList<Flights> GetFlightsByDepatrureDate(DateTime depatrureDate);
        IList<Flights> GetFlightsByLandingDate (DateTime landingDate);
        IList<Flights> GetFlightsByCustomer(Customers customer);

    }
}
