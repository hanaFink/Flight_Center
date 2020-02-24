using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center.Facade
{
    class LoggedInCustomerFacade : AnonymousUserFacade, ILoggedInCustomerFacade
    {
        public void CancelTicket(LoginToken<Customer> token, Ticket ticket)
        {
            if (token.User.ID == ticket.CUSTOMER_ID)
            {
                Flight f = _flightDAO.Get(ticket.FLIGHT_ID);
                _ticketDAO.Remove(ticket);
                f.REMAINING_TICKETS++;
                _flightDAO.Update(f);
            }
            else
            {
                throw new NotCustomerFlightExeption(ticket);
            }
        }

        public IList<Flight> GetAllMyFlights(LoginToken<Customer> token)
        {
            throw new NotImplementedException();
        }

        public Ticket PerchaseTicket(LoginToken<Customer> token, Flight flight)
        {

            if (flight.REMAINING_TICKETS > 0)
            {
                flight.REMAINING_TICKETS--;
                Ticket newTicket = new Ticket { CUSTOMER_ID = (int)token.User.ID, FLIGHT_ID = (int)flight.ID };
                 _ticketDAO.Add(newTicket);
                return newTicket;
            }
            else
            {
                throw new FlightDoNotHaveVacancyTicketsExeption(flight);
            }


        }
    }

    }
}
      