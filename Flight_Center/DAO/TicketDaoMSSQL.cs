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
        public void Add(Ticket ticketToAdd)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Tickets VALUES ({ticketToAdd.FLIGHT_ID},{ticketToAdd.CUSTOMER_ID})", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }
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

                            getTicket.ID =Convert.ToInt32(reader["ID"]);
                            getTicket.FLIGHT_ID = Convert.ToInt32(reader["FLIGHT_ID"]);
                            getTicket.CUSTOMER_ID = Convert.ToInt32(reader["CUSTOMER_ID"]);
                      
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

                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                FLIGHT_ID = Convert.ToInt32(reader["FLIGHT_ID"]),
                                CUSTOMER_ID = Convert.ToInt32(reader["CUSTOMER_ID"])
                            };


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

                using (SqlCommand cmd = new SqlCommand($"DELETE FROM Tickets WHERE ID = {ticketToRemove.ID}", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Update(Ticket ticketToUpdate)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"UPDATE Tickets  SET [FLIGHT_ID] = {ticketToUpdate.FLIGHT_ID},[CUSTOMER_ID] = {ticketToUpdate.CUSTOMER_ID} WHERE ID = {ticketToUpdate.ID}", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }

        }
        /// <summary>
        /// get all tickets that airline have
        /// </summary>
        /// <param name="airlineId">specific airlinecompany </param>
        /// <returns></returns>
        public IList<Ticket> GetAllTicketsByAirlineId(Int64 airlineId)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                IList<Ticket> listOfTickets = new List<Ticket>();// create list of tickets



                using (SqlCommand cmd = new SqlCommand($"SELECT T.* FROM Tickets T JOIN  Flights F ON F.ID = T.FLIGHT_ID WHERE F.AIRLINECOMPANY_ID = {airlineId}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Ticket ticket = new Ticket

                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                FLIGHT_ID = Convert.ToInt32(reader["FLIGHT_ID"]),
                                CUSTOMER_ID = Convert.ToInt32(reader["CUSTOMER_ID"])
                            };


                            listOfTickets.Add(ticket);
                        }


                    }

                }
                return listOfTickets;
            }
        }

    }
}
