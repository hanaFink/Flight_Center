using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    class LoginService : ILogicService
    {
        private IAirlineDAO _airlineDAO;
        private ICustomerDAO _customerADO;

        /// <summary>
        /// method check if username belongs to administrator and password is suitable for username
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="token">if administrator exist out it's user details</param>
        /// <returns> boolian return true if username ad password belongs to adminisrator, else return false </returns>
        public bool TryAdministratorLogin(string userName, string password, out LoginToken<Administrator> token)
        {

            if (Administrator.username == userName)

            {


                if (Administrator.password == password)
                {

                    token = new LoginToken<Administrator>();// need to check;
                    token.User = new Administrator();
                    return true;

                }

                else
                {
                    throw new WrongPasswors(userName);
                }
            }
            else
            {
                token = null;
                return false;
            }
        }
        /// <summary>
        /// method check if username belongs to Airlinecompany and password is suitable for username
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="token">if Airlinecompany exist out it's user details</param>
        /// <returns>boolian return true if username ad password belongs to Airlinecompany, else return false</returns>
        public bool TryAirlineLogin(string userName, string password, out LoginToken<AirlineCompanie> token)
        {

            if (_airlineDAO.GetAirlineCompaniesByUsername(userName) != null)
            {
                if (_airlineDAO.GetAirlineCompaniesByUsername(userName).PASSWORD == password)
                {
                    token = new LoginToken<AirlineCompanie>();// need to check;
                    token.User = _airlineDAO.GetAirlineCompaniesByUsername(userName);
                    return true;

                }
                else
                {
                    throw new WrongPasswors(userName);
                }
            }
            else
            {
                token = null;
                return false;
            }
            

        }
        /// <summary>
        /// method check if username belongs to customer and password is suitable for username
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="token">if customer exist out it's user details</param>
        /// <returns>boolian return true if username ad password belongs to customer, else return false</returns>
        public bool TryCustomereLogin(string userName, string password, out LoginToken<Customer> token)
        {

            if (_customerADO.GetCustomerByUsername(userName) != null)
            {
                if (_customerADO.GetCustomerByUsername(userName).PASSWORD == password)
                {
                    token = new LoginToken<Customer>();// need to check;
                    token.User = _customerADO.GetCustomerByUsername(userName);
                    return true;

                }
                else
                {
                    throw new WrongPasswors(userName);
                }
            }
            else
            {
                token = null;
                return false;
            }

        }
    }
}
