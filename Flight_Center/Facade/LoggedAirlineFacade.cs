using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center.Facade
{
    class LoggedAirlineFacade : AnonymousUserFacade, ILoggedAirlineFacade
    {
        public void CancelFlight(LoginToken<AirlineCompanie> token, Flight flight)
        {
            throw new NotImplementedException();
        }

        public void ChangeMyPassword(LoginToken<AirlineCompanie> token, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void CreateFlight(LoginToken<AirlineCompanie> token, Flight flight)
        {
            throw new NotImplementedException();
        }

        public IList<Ticket> GetAllFlights(LoginToken<AirlineCompanie> token)
        {
            throw new NotImplementedException();
        }

        public IList<Ticket> GetAllTickets(LoginToken<AirlineCompanie> token)
        {
            throw new NotImplementedException();
        }

        public void ModifyAirlineDetails(LoginToken<AirlineCompanie> token, AirlineCompanie airline)
        {
            throw new NotImplementedException();
        }

        public void UpdateFlight(LoginToken<AirlineCompanie> token, Flight flight)
        {
            throw new NotImplementedException();
        }
    }
}
