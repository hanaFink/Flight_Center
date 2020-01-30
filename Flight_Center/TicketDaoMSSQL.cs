using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Flight_Center
{
    public class TicketDaoMSSQL : ITicketDAO
    {
        string _path = Flight_Center_Appconfig.path;
        public void Add(Ticket t)
        {
            throw new NotImplementedException();
        }

        public Ticket Get(int id)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Tickets WHERE ID = {id}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Ticket getTicket = new Ticket();

                        while (reader.Read())
                        {

                            getTicket.ID = (int)reader["ID"];
                            getTicket.FLIGHT_ID = (int)reader["FLIGHT_ID"];
                            getTicket.CUSTOMER_ID = (int)reader["CUSTOMER_ID"];
                      
                        }

                        return getTicket;
                    }

                }
            }
        }

        public IList<Ticket> GetAll()
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                IList<Ticket> listOfTickets =new List<Ticket>();// create list of tickets

               

                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Tickets ", con))
                    {

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                           

                            while (reader.Read())
                            {
                                Ticket ticket = new Ticket
                                { ID = (int)reader["ID"],
                                  FLIGHT_ID = (int)reader["FLIGHT_ID"],
                                  CUSTOMER_ID = (int)reader["CUSTOMER_ID"] };


                             listOfTickets.Add(ticket);
                            }

                            
                        }
                   
                }
                return listOfTickets;
            }
        }

        public void Remove(Ticket ticketToRemove)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"DELETE FROM Ticket WHERE ID = {ticketToRemove.ID}", con))
                {


                }
            }
        }

        public void Update(Ticket ticketToUpdate)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"UPDATE Ticket  SET[FLIGHT_ID] = {ticketToUpdate.FLIGHT_ID},[CUSTOMER_ID] = {ticketToUpdate.CUSTOMER_ID}, WHERE ID = {ticketToUpdate.ID}", con))
                {


                }
            }

        }
    
    }
}
