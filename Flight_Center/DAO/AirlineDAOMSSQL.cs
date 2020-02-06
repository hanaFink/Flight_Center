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

                            getAirline.ID = Convert.ToInt32(reader["ID"]);
                            getAirline.AIRLINE_NAME = Convert.ToString(reader["AIRLINE_NAME"]);
                            getAirline.USER_NAME = Convert.ToString(reader["USER_NAME"]);
                            getAirline.PASSWORD = Convert.ToString(reader["PASSWORD"]);
                            getAirline.COUNTRY_CODE = Convert.ToInt32(reader["COUNTRY_CODE"]);

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

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM AirlineCompanies WHERE USER_NAME LIKE '{name}' ", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        AirlineCompanie getAirline = new AirlineCompanie();

                        while (reader.Read())
                        {

                            getAirline.ID = Convert.ToInt32(reader["ID"]);
                            getAirline.AIRLINE_NAME = Convert.ToString(reader["AIRLINE_NAME"]);
                            getAirline.USER_NAME = Convert.ToString(reader["USER_NAME"]);
                            getAirline.PASSWORD = Convert.ToString(reader["PASSWORD"]);
                            getAirline.COUNTRY_CODE  = Convert.ToInt32(reader["COUNTRY_CODE"]);

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
                            ID =Convert.ToInt32(reader["ID"]),
                            AIRLINE_NAME =Convert.ToString(reader["AIRLINE_NAME"]),
                            USER_NAME =Convert.ToString(reader["USER_NAME"]),
                            PASSWORD = Convert.ToString( reader["PASSWORD"]),
                            COUNTRY_CODE = Convert.ToInt32(reader["COUNTRY_CODE"])

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
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                IList<AirlineCompanie> listOfCompanies = new List<AirlineCompanie>();// create list of Airline Companies

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM AirlineCompanies WHERE COUNTRY_CODE = {countryid}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            AirlineCompanie airlineCompanie = new AirlineCompanie
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                AIRLINE_NAME = Convert.ToString(reader["AIRLINE_NAME"]),
                                USER_NAME = Convert.ToString(reader["USER_NAME"]),
                                PASSWORD = Convert.ToString(reader["PASSWORD"]),
                                COUNTRY_CODE = Convert.ToInt32(reader["COUNTRY_CODE"])

                            };


                            listOfCompanies.Add(airlineCompanie);
                        }


                    }

                }
                return listOfCompanies;
            }
        }

        public void Remove(AirlineCompanie t) // using cascade
        {

               using (SqlConnection con = new SqlConnection(_path)) // Connection String
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM AirlineCompanies WHERE ID = {t.ID}", con))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }


    }

        public void Update(AirlineCompanie t)
        {
            

                using (SqlConnection con = new SqlConnection(_path)) // Connection String
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand($"UPDATE AirlineCompanies SET [AIRLINE_NAME] = {t.AIRLINE_NAME},[USER_NAME] = {t.USER_NAME} WHERE ID = {t.ID}", con))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }

            
        }
    }
}
