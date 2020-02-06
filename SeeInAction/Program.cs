using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Center;
using System.Data.SqlClient;

namespace SeeInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket1 = new Ticket();
            TicketDaoMSSQL ticketdao = new TicketDaoMSSQL();
          ticket1 = ticketdao.Get(1);
            Console.WriteLine(ticket1);
            Ticket ticket2 = new Ticket
           {ID =11,
           CUSTOMER_ID = 1,
          FLIGHT_ID = 3
          };


           // b.Add(c);
           ticket1 = ticketdao.Get(Convert.ToInt32(ticket2.ID));
            Console.WriteLine(ticket2);
            ticketdao.Update(ticket2);

            AirlineCompanie company1 = new AirlineCompanie();
            AirlineDAOMSSQL airlineDAOMSSQL = new AirlineDAOMSSQL();
            company1 = airlineDAOMSSQL.Get(9);
            Console.WriteLine(company1);
            company1 = airlineDAOMSSQL.GetAirlineCompaniesByUsername("Air Corsica");
            Console.WriteLine(company1);

            IList<AirlineCompanie> listcompanies1 = new List<AirlineCompanie>();
            listcompanies1 = airlineDAOMSSQL.GetAllAirlinesCompanyByCountry(19);
            foreach (var item in listcompanies1)
            {
                Console.WriteLine(item);
            }

            IList<AirlineCompanie> listcompanies2 = new List<AirlineCompanie>();


            listcompanies2 = airlineDAOMSSQL.GetAll();
            foreach (var item in listcompanies2)
            {
                Console.WriteLine(item);
            }



            AirlineCompanie company3 = new AirlineCompanie()

            {
          
                AIRLINE_NAME = "'Air New'",
                USER_NAME = "'Air New'",
                PASSWORD = "'9876543'",
                COUNTRY_CODE = 19
            };

           // airlineDAOMSSQL.Add(company3);
            Console.WriteLine(airlineDAOMSSQL.Get(26));
           

        }
    }
}
