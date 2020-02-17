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
            if (token.User.ID == flight.AIRLINECOMPANY_ID)
            {

                _flightDAO.Remove(flight);
            }
            else
            {
                throw new NotYourFlightException(token);
            }
        }

        public void ChangeMyPassword(LoginToken<AirlineCompanie> token, string oldPassword, string newPassword)
        {
            if (token.User.PASSWORD == oldPassword)
            {
                token.User.PASSWORD = newPassword;
                _airlineDao.Update(token.User);
            }
            else
            {
                throw new WrongPasswors(token.User.AIRLINE_NAME);
            }
        }

        public void CreateFlight(LoginToken<AirlineCompanie> token, Flight flight)
        {
            if (token.User.ID == flight.AIRLINECOMPANY_ID)
            {
                _flightDAO.Add(flight);
            }
            else
            {
                throw new NotYourFlightException(token);
            }
        }

        public IList<Flight> GetAllFlights(LoginToken<AirlineCompanie> token)
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
