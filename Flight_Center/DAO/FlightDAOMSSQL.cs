using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    class FlightDAOMSSQL : IFlightDAO
    {

        string _path = Flight_Center_Appconfig.path;
        public void Add(Flights flightToAdd)
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

        

        public Flights Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dictionary<Flights, int> GetAllFlithtsVacancy()
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByDepatrureDate(DateTime depatrureDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByDistinationCountry(int countryCode)
        {
            throw new NotImplementedException();
        }

        public Flights GetFlightsById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByLandingDate(DateTime landingDate)
        {
            throw new NotImplementedException();
        }

        public IList<Flights> GetFlightsByOriginCountry(int countryCode)
        {
            throw new NotImplementedException();
        }

        public void Remove(Flights t)
        {
            throw new NotImplementedException();
        }

        public void Update(Flights t)
        {
            throw new NotImplementedException();
        }
    }
}
