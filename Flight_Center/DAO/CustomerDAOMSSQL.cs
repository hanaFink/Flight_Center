using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class CustomerDAOMSSQL : ICustomerDAO
    {
        string _path = Flight_Center_Appconfig.path;
        
        public void Add(Customer customerToAdd)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Customers VALUES ({customerToAdd.FIRST_NAME},{customerToAdd.LAST_NAME},{customerToAdd.USER_NAME},{customerToAdd.PASSWORD},{customerToAdd.ADDRESS},{customerToAdd.PHONE_NO},{customerToAdd.CREDIT_CARD_NUMBER}", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public Customer Get(int id)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Customers WHERE ID = {id}", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Customer getCustomer = new Customer();

                        while (reader.Read())
                        {

                            getCustomer.ID = Convert.ToInt32(reader["ID"]);
                            getCustomer.FIRST_NAME = (string)reader["FIRST_NAME"];
                            getCustomer.LAST_NAME = (string)reader["LAST_NAME"];
                            getCustomer.USER_NAME = (string)reader["USER_NAME"];
                            getCustomer.PASSWORD = (string)reader["PASSWORD"];
                            getCustomer.ADDRESS = (string)reader["ADDRESS"];
                            getCustomer.PHONE_NO = (string)reader["PHONE_NO"];
                            getCustomer.CREDIT_CARD_NUMBER = (string)reader["CREDIT_CARD_NUMBER"];

           
                        }

                        return getCustomer;
                    }

                }
            }
        }

        public IList<Customer> GetAll()
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Customers ", con))
                {
                    IList<Customer> listOfcustimers = new List<Customer>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Customer getCustomer = new Customer();

                        while (reader.Read())
                        {

                            getCustomer.ID = Convert.ToInt32(reader["ID"]);
                            getCustomer.FIRST_NAME = (string)reader["FIRST_NAME"];
                            getCustomer.LAST_NAME = (string)reader["LAST_NAME"];
                            getCustomer.USER_NAME = (string)reader["USER_NAME"];
                            getCustomer.PASSWORD = (string)reader["PASSWORD"];
                            getCustomer.ADDRESS = (string)reader["ADDRESS"];
                            getCustomer.PHONE_NO = (string)reader["PHONE_NO"];
                            getCustomer.CREDIT_CARD_NUMBER = (string)reader["CREDIT_CARD_NUMBER"];


                        }

                        listOfcustimers.Add(getCustomer);
                    }
                    return listOfcustimers;

                }
            }
        }

        public Customer GetCustomerByUsername(string name)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Customers WHERE USER_NAME LIKE '{name}'", con))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Customer getCustomer = new Customer();

                        while (reader.Read())
                        {

                            getCustomer.ID = Convert.ToInt32(reader["ID"]);
                            getCustomer.FIRST_NAME = (string)reader["FIRST_NAME"];
                            getCustomer.LAST_NAME = (string)reader["LAST_NAME"];
                            getCustomer.USER_NAME = (string)reader["USER_NAME"];
                            getCustomer.PASSWORD = (string)reader["PASSWORD"];
                            getCustomer.ADDRESS = (string)reader["ADDRESS"];
                            getCustomer.PHONE_NO = (string)reader["PHONE_NO"];
                            getCustomer.CREDIT_CARD_NUMBER = (string)reader["CREDIT_CARD_NUMBER"];


                        }

                        return getCustomer;
                    }

                }
            }
        }

        public void Remove(Customer customerToRemove)
        {
            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"DELETE FROM Customers WHERE ID = {customerToRemove.ID}", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Update(Customer customerToUpdate)
        {

            using (SqlConnection con = new SqlConnection(_path)) // Connection String
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"UPDATE Customers  SET [FIRST_NAME] = {customerToUpdate.FIRST_NAME},[LAST_NAME] = {customerToUpdate.LAST_NAME},[ADDRESS] = {customerToUpdate.ADDRESS},[PHONE_NO] = {customerToUpdate.PHONE_NO},[CREDIT_CARD_NUMBER] = {customerToUpdate.CREDIT_CARD_NUMBER}  WHERE ID = {customerToUpdate.ID}", con))
                {
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
