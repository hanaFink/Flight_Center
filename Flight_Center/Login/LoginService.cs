using Flight_Center.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public class LoginService : ILogicService
    {
        private IAirlineDAO _airlineDAO;
        private ICustomerDAO _customerADO;


        /*
        public LoginService()

        
          /*  string userName = Console.ReadLine();
            string password = Console.ReadLine();



            TryAdministratorLogin(userName, password, out LoggedInAdministratorFacade loggedInAdministratorFacade, out LoginToken<Administrator> token);


            TryAirlineLogin(userName, password, out LoggedInAirlineFacade loggedInAirlineFacade, out LoginToken<AirlineCompanie> token1);

            TryCustomereLogin(userName, password, out LoggedInCustomerFacade loggedInCustomerFacade, out LoginToken<Customer> token2);

        }

        */

        /// <summary>
        /// method check if username belongs to administrator and password is suitable for username
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="token">if administrator exist out it's user details</param>
        /// <returns> boolian return true if username ad password belongs to adminisrator, else return false </returns>
      
        public void TryAdministratorLogin(string userName, string password,out LoggedInAdministratorFacade loggedInAdministratorFacade,   out LoginToken<Administrator> token)
        {
            loggedInAdministratorFacade = null;

            if (Administrator.username == userName)

            {


                if (Administrator.password == password)
                {

                    token = new LoginToken<Administrator>();// need to check;
                    token.User = new Administrator();
                  

                }

                else
                {
                    throw new WrongPasswors(userName);
                }
            }
            else
            {
                token = null;
            }
        }
        /// <summary>
        /// method check if username belongs to Airlinecompany and password is suitable for username
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="token">if Airlinecompany exist out it's user details</param>
        /// <returns>boolian return true if username ad password belongs to Airlinecompany, else return false</returns>

        public void TryAirlineLogin(string userName, string password, out LoggedInAirlineFacade loggedInAirlineFacade, out LoginToken<AirlineCompanie> token)
        {
            loggedInAirlineFacade = null;
            {

                if (_airlineDAO.GetAirlineCompaniesByUsername(userName) != null)
                {
                    if (_airlineDAO.GetAirlineCompaniesByUsername(userName).PASSWORD == password)
                    {
                        token = new LoginToken<AirlineCompanie>();// need to check;
                        token.User = _airlineDAO.GetAirlineCompaniesByUsername(userName);

                    }
                    else
                    {
                        throw new WrongPasswors(userName);
                    }
                }
                else
                {
                    token = null;
                }

            }
        }
        /// <summary>
        /// method check if username belongs to customer and password is suitable for username
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="token">if customer exist out it's user details</param>
        /// <returns>boolian return true if username ad password belongs to customer, else return false</returns>

        public void TryCustomereLogin(string userName, string password,out LoggedInCustomerFacade loggedInCustomerFacade, out LoginToken<Customer> token)
        
                {
                loggedInCustomerFacade = null;

                    if (_customerADO.GetCustomerByUsername(userName) != null)
                    {
                        if (_customerADO.GetCustomerByUsername(userName).PASSWORD == password)
                        {
                            token = new LoginToken<Customer>();// need to check;
                            token.User = _customerADO.GetCustomerByUsername(userName);

                        }
                        else
                        {
                            throw new WrongPasswors(userName);
                        }
                    }
                    else
                    {
                        token = null;
                    }
                }

    }
}
