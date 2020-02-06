using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class CountryDAOMSSQL : ICountryDAO
    {
        string _path = Flight_Center_Appconfig.path;
        public void Add(Countries countryToAdd)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Countries VALUES ({countryToAdd.COUNTRY_NAME}", con))

                {
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public Countries Get(int id)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Countries WHERE ID = {id}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Countries getCountry = new Countries();

                        while (reader.Read())
                        {

                            getCountry.ID = Convert.ToInt32(reader["ID"]);
                            getCountry.COUNTRY_NAME = Convert.ToString(reader["COUNTRY_NAME"]);
                          

                        }

                        return getCountry;
                    }

                }
            }
        }

        public IList<Countries> GetAll()
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                IList<Countries> listOfCountries = new List<Countries>();// create list of countries



                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Countries ", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Countries country = new Countries()

                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                COUNTRY_NAME = Convert.ToString(reader["COUNTRY_NAME"])

                        };


                           listOfCountries.Add(country);
                        }


                    }

                }
                return listOfCountries;
            }
        }

        public void Remove(Countries t)
        {
            Console.WriteLine("You can't remove country");
        }

        public void Update(Countries countryToUpdate)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"UPDATE Countries  SET [COUNTRY_NAME] = {countryToUpdate.COUNTRY_NAME} WHERE ID = {countryToUpdate.ID}", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
