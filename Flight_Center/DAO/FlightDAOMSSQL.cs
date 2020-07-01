using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class FlightDAOMSSQL : IFlightDAO
    {

        string _path = Flight_Center_Appconfig.path;
        public void Add(Flight flightToAdd)
        {

       
                using (SqlConnection con = new SqlConnection(_path)) // Connection String
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand($"INSERT INTO Flights VALUES ({flightToAdd.AIRLINECOMPANY_ID},{flightToAdd.ORIGIN_COUNTRY_CODE},{flightToAdd.DESTINATION_COUNTRY_CODE},{flightToAdd.DEPARTURE_TIME},{flightToAdd.ACTUAL_DEPARTURE_TIME},{flightToAdd.LANDING_TIME},{flightToAdd.ACTUAL_LANDING_TIME},{flightToAdd.REMAINING_TICKETS}", con))
                    {

                        cmd.ExecuteNonQuery();

                    }
                }
            }



        public Flight Get(int id)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights WHERE ID = {id}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        return getFlight;
                    }
                }


            }
        }

            public IList<Flight> GetAll()
        { 
        
            

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                IList<Flight> listOfFlights = new List<Flight>();// create list of tickets

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights", con))
            {

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Flight getFlight = new Flight();

                    while (reader.Read())
                    {

                        getFlight.ID = Convert.ToInt32(reader["ID"]);
                        getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                        getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                        getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                        getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                        getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                        getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                        getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                        getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                    }
                    listOfFlights.Add(getFlight);
                }
            }

                return listOfFlights;
        }
    }

        public Dictionary<Flight, int> GetAllFlightsVacancy()
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                Dictionary<Flight, int> listOfFlights = new Dictionary<Flight, int>();

                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights WHERE REMAINING_TICKETS > 0", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        listOfFlights.Add(getFlight,getFlight.REMAINING_TICKETS);
                    }
                }

                return listOfFlights;
            }
        }

        public IList<Flight> GetFlightsByCustomer(Customer customer)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                IList<Flight> ListOfFlightsByCustomer = new List<Flight>();

                using (SqlCommand cmd = new SqlCommand($"select * from Flights F join Tickets T on f.ID = T.FLIGHT_ID join Customers C on c.ID = T.CUSTOMER_ID where T.CUSTOMER_ID = {customer.ID}"))
                { 

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        ListOfFlightsByCustomer.Add(getFlight);
                    }
                }

                return ListOfFlightsByCustomer;
            }
        }

        public IList<Flight> GetFlightsByDepatrureDate(DateTime depatrureDate)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                IList<Flight> ListOfFlightsBydepatrureDate = new List<Flight>();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights WHERE DEPARTURE_TIME = {depatrureDate}"))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        ListOfFlightsBydepatrureDate.Add(getFlight);
                    }
                }

                return ListOfFlightsBydepatrureDate;
            }
        }
    

        public IList<Flight> GetFlightsByDistinationCountry(int countryCode)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                IList<Flight> ListOfFlightsBycountryCode = new List<Flight>();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights WHERE DESTINATION_COUNTRY_CODE = {countryCode}"))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        ListOfFlightsBycountryCode.Add(getFlight);
                    }
                }

                return ListOfFlightsBycountryCode;
            }
        }

        public IList <Flight> GetFlightsByAirlineId(Int64 aircompanyid)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                IList<Flight> listOfFlights = new List<Flight>();

                con.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights WHERE AIRLINECOMPANY_ID = {aircompanyid}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        listOfFlights.Add(getFlight);
                    }
                }
                return listOfFlights;

            }
        }

        public IList<Flight> GetFlightsByLandingDate(DateTime landingDate)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                IList<Flight> ListOfFlightslandingDate = new List<Flight>();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights WHERE LANDING_TIME = {landingDate}"))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        ListOfFlightslandingDate.Add(getFlight);
                    }
                }

                return ListOfFlightslandingDate;
            }
        }

        public IList<Flight> GetFlightsByOriginCountry(int countryCode)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                IList<Flight> ListOfFlightsBycountryCode = new List<Flight>();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights WHERE ORIGIN_COUNTRY_CODE = {countryCode}"))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        ListOfFlightsBycountryCode.Add(getFlight);
                    }
                }

                return ListOfFlightsBycountryCode;
            }
        }

        public void Remove(Flight flightToRemove)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {

                
                con.Open();
           

                            using (SqlCommand cmd1 = new SqlCommand($"DELETE FROM Flights WHERE ID = {flightToRemove.ID}", con))
                {
                    cmd1.ExecuteNonQuery();

                }
            }
        }

        public void Update(Flight FlightToUpdate)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"UPDATE Tickets  SET [AIRLINECOMPANY_ID] = {FlightToUpdate.AIRLINECOMPANY_ID},[ORIGIN_COUNTRY_CODE] = {FlightToUpdate.ORIGIN_COUNTRY_CODE},[DESTINATION_COUNTRY_CODE] = {FlightToUpdate.DESTINATION_COUNTRY_CODE},[DEPARTURE_TIME] = {FlightToUpdate.DEPARTURE_TIME},[ACTUAL_DEPARTURE_TIME] = {FlightToUpdate.ACTUAL_DEPARTURE_TIME}, [LANDING_TIME] = {FlightToUpdate.LANDING_TIME},[ACTUAL_LANDING_TIME] = {FlightToUpdate.ACTUAL_LANDING_TIME} WHERE ID = {FlightToUpdate.ID}", con))
                {
                    
                        cmd.ExecuteNonQuery();

                }
            }
        }
        /// <summary>
        /// select all flights whith landing time over 3 hours from now 
        /// </summary>
        /// <param name="landingTime"></param>
        /// <returns>list of flights</returns>
        public IList<Flight> GetFlightsByOldDate()
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                IList<Flight> ListOfFlightsByLandingTime = new List<Flight>();
                DateTime date = DateTime.Now;
                Convert.ToInt32(date.Hour);
                int date1 = Convert.ToInt32(date.Hour) -3;
                

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Flights where (select DATEPART(HOUR,LANDING_TIME ) hour) <{date1}"))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Flight getFlight = new Flight();

                        while (reader.Read())
                        {

                            getFlight.ID = Convert.ToInt32(reader["ID"]);
                            getFlight.AIRLINECOMPANY_ID = Convert.ToInt32(reader["AIRLINECOMPANY_ID"]);
                            getFlight.ORIGIN_COUNTRY_CODE = Convert.ToInt32(reader["ORIGIN_COUNTRY_CODE"]);
                            getFlight.DESTINATION_COUNTRY_CODE = Convert.ToInt32(reader["DESTINATION_COUNTRY_CODE"]);
                            getFlight.LANDING_TIME = Convert.ToDateTime(reader["LANDING_TIME"]);
                            getFlight.ACTUAL_LANDING_TIME = Convert.ToDateTime(reader["ACTUAL_LANDING_TIME"]);
                            getFlight.DEPARTURE_TIME = Convert.ToDateTime(reader["DEPARTURE_TIME"]);
                            getFlight.ACTUAL_DEPARTURE_TIME = Convert.ToDateTime(reader["ACTUAL_DEPARTURE_TIME"]);
                            getFlight.REMAINING_TICKETS = Convert.ToInt32(reader["REMAINING_TICKETS"]);


                        }
                        ListOfFlightsByLandingTime.Add(getFlight);
                    }
                }

                return ListOfFlightsByLandingTime;
            }
        }
     /// <summary>
     /// Adding list of flights to Old_Flights tabe
     /// </summary>
     /// <param name="flightsToAdd">list of flights</param>
            public void AddToOld_Flights(IList<Flight> flightsToAdd)
            {


            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();
                foreach (Flight flightToAdd in flightsToAdd)
                {


                    using (SqlCommand cmd = new SqlCommand($"INSERT INTO Old_Flights VALUES ({flightToAdd.AIRLINECOMPANY_ID},{flightToAdd.ORIGIN_COUNTRY_CODE},{flightToAdd.DESTINATION_COUNTRY_CODE},{flightToAdd.DEPARTURE_TIME},{flightToAdd.ACTUAL_DEPARTURE_TIME},{flightToAdd.LANDING_TIME},{flightToAdd.ACTUAL_LANDING_TIME},{flightToAdd.REMAINING_TICKETS}", con))
                    {

                        cmd.ExecuteNonQuery();

                    }
                }
            }
                
            }
        /// <summary>
        /// Removing list of flights from Flight table
        /// </summary>
        /// <param name="flightToRemove">list of flights</param>
        public void RemoveListOfFlights(IList<Flight> flightToRemove)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {

                con.Open();
                foreach (Flight getFlight in flightToRemove)
                {
                    using (SqlCommand cmd1 = new SqlCommand($"DELETE FROM Flights WHERE ID = {getFlight.ID}", con))
                    {
                        cmd1.ExecuteNonQuery();

                    }
                }
            }
        }




    }
    }
