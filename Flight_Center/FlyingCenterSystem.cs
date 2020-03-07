using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Flight_Center
{
    public class FlyingCenterSystem
    {
        private static FlyingCenterSystem _instance;
        private static object key = new object();
        public static IFlightDAO _flightDAO;
        public static ITicketDAO _ticketDAO;
        static FlyingCenterSystem()
        {
        }

        private FlyingCenterSystem()
        {
            _flightDAO = new FlightDAOMSSQL();
            _ticketDAO = new TicketDaoMSSQL();
             
            while (true)
            {
                TimeSpan interval = new TimeSpan(24, 0, 0);
                Thread.Sleep(interval);
               IList <Flight> listOfFlights = _flightDAO.GetFlightsByOldDate();
                _flightDAO.AddToOld_Flights(listOfFlights);
                _flightDAO.RemoveListOfFlights(listOfFlights);
                IList<Ticket> listOfTickets = _ticketDAO.GetTicketsByFlightId(listOfFlights);
                _ticketDAO.AddToOldTickets(listOfTickets);
                _ticketDAO.RemoveListOfTickets(listOfTickets);

            }
            
        }
        public static FlyingCenterSystem GetInstance()
        {
            if (_instance == null)
            {
                lock(key)
                {
                    if (_instance == null)
                        _instance = new FlyingCenterSystem();
                }
               
            }
           
                return _instance;

        }
      /*  public static T GetFacade <T> (string username, string password)
        {

            
            LoginService login = new LoginService();
            LoginToken<Administrator> t = new LoginToken<Administrator>();
            LoginToken<AirlineCompanie> t1 = new LoginToken<AirlineCompanie>();
            LoginToken<Customer> t2 = new LoginToken<Customer>();

            if (login.TryAdministratorLogin(username, password, out t) == true)
            {
               bool a = login.TryAdministratorLogin(username, password, out t)
                return  ;
            }
            else if (login.TryAirlineLogin(username, password, out t1) == true)
            {

            }
           else if (login.TryCustomereLogin(username,password, out t2) == true)
            {

            }

        }*/
    }
}
