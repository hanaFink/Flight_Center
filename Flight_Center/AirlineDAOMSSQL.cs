using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flight_Center
{
    public class AirlineDAOMSSQL : IAirlineDAO
    {
        string _path = Flight_Center_Appconfig.path;
        public void Add(AirlineCompanie airlineToAdd)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"INSERT INTO AirlineCompanies VALUES  ({airlineToAdd.AIRLINE_NAME},{airlineToAdd.USER_NAME},{airlineToAdd.PASSWORD},{airlineToAdd.COUNTRY_CODE})", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }
        }


        public AirlineCompanie Get(int id)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM AirlineCompanies WHERE ID = {id}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        AirlineCompanie getAirline = new AirlineCompanie();

                        while (reader.Read())
                        {

                            getAirline.ID = (int)reader["ID"];
                            getAirline.AIRLINE_NAME = (string)reader["AIRLINE_NAME"];
                            getAirline.USER_NAME = (string)reader["USER_NAME"];
                            getAirline.PASSWORD = (string)reader["PASSWORD"];
                            getAirline.COUNTRY_CODE = (string)reader["COUNTRY_CODE"];

                        }

                        return getAirline;
                    }

                }
            }
        }

        public AirlineCompanie GetAirlineCompaniesByUsername(string name)
        { 
        using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM AirlineCompanies WHERE AIRLINE_NAME = {name}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        AirlineCompanie getAirline = new AirlineCompanie();

                        while (reader.Read())
                        {

                            getAirline.ID = (int) reader["ID"];
                            getAirline.AIRLINE_NAME = (string) reader["AIRLINE_NAME"];
                            getAirline.USER_NAME = (string) reader["USER_NAME"];
                            getAirline.PASSWORD =(string) reader["PASSWORD"];
                            getAirline.COUNTRY_CODE = (string) reader["COUNTRY_CODE"];

                         }

                        return getAirline;
                    }

                }
            }
           }

        public IList<AirlineCompanie> GetAll()
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                IList<AirlineCompanie> listOfCompanies = new List<AirlineCompanie>();// create list of Airline Companies

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM AirlineCompanies", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            AirlineCompanie airlineCompanie = new AirlineCompanie
                            {
                            ID = (int)reader["ID"],
                            AIRLINE_NAME = (string)reader["AIRLINE_NAME"],
                            USER_NAME = (string)reader["USER_NAME"],
                            PASSWORD = (string)reader["PASSWORD"],
                            COUNTRY_CODE = (string)reader["COUNTRY_CODE"]

                        };


                            listOfCompanies.Add(airlineCompanie);
                        }


                    }

                }
                return listOfCompanies;
            }

        }



                    public IList<AirlineCompanie> GetAllAirlinesCompanyByCountry(int countryid)
        {
            throw new NotImplementedException();
        }

        public void Remove(AirlineCompanie t)
        {
            throw new NotImplementedException();
        }

        public void Update(AirlineCompanie t)
        {
            throw new NotImplementedException();
        }
    }
}
