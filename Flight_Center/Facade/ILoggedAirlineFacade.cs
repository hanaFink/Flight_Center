using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center.Facade
{
    interface ILoggedAirlineFacade
    {
        IList<Ticket> GetAllTickets(LoginToken<AirlineCompanie> token);
        IList<Flight> GetAllFlights(LoginToken<AirlineCompanie> token);
        void CancelFlight(LoginToken<AirlineCompanie> token, Flight flight);
        void CreateFlight(LoginToken<AirlineCompanie> token, Flight flight);
        void UpdateFlight(LoginToken<AirlineCompanie> token, Flight flight);
        void ChangeMyPassword(LoginToken<AirlineCompanie> token, string oldPassword, string newPassword);
        void ModifyAirlineDetails(LoginToken<AirlineCompanie> token, AirlineCompanie airline);

    }
}
