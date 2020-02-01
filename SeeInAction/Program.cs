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
            Ticket a = new Ticket();
            TicketDaoMSSQL b = new TicketDaoMSSQL();
          a = b.Get(1);
            Console.WriteLine(a);
            Ticket c = new Ticket
           {ID =11,
           CUSTOMER_ID = 1,
          FLIGHT_ID = 3
          };
          
     
         

           // b.Add(c);
           a = b.Get(Convert.ToInt32(c.ID));
            Console.WriteLine(c);
            b.Update(c);
        }
    }
}
