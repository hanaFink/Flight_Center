using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Flight_Center
{
    public class FlyingCenterSystem
    {
        private static readonly FlyingCenterSystem instance = new FlyingCenterSystem();
  
        static FlyingCenterSystem()
        {
        }
        private FlyingCenterSystem()
        {
            while (true)
            {
                TimeSpan interval = new TimeSpan(24, 0, 0);
                Thread.Sleep(interval);
            }
            
        }
        public static FlyingCenterSystem Instance
        {
            get
            {
                return instance;
            }
        }
      /*  public static T GetFacade <T> (string username, string password)
        {

            
            LoginService login = new LoginService();
            LoginToken<Administrator> t = new LoginToken<Administrator>();
            LoginToken<AirlineCompanie> t1 = new LoginToken<AirlineCompanie>();
            LoginToken<Customer> t2 = new LoginToken<Customer>();

            if (login.TryAdministratorLogin(username, password, out t) == true)
            {
               bool a = login.TryAdministratorLogin(username, password, out t)
                return  ;
            }
            else if (login.TryAirlineLogin(username, password, out t1) == true)
            {

            }
           else if (login.TryCustomereLogin(username,password, out t2) == true)
            {

            }

        }*/
    }
}
