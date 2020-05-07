using Flight_Center;
using Flight_Center.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ApiFlight_Center.Controllers
{
    public class AirlineController : ApiController
    {

        // temporary code ... will be replaced !!!!!!!!!!!!!!!!!1
        private void GetFacadeAndToken(out LoggedAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token)
        {
            LoginService loginService = new LoginService();
            loginService.TryAirlineLogin("elal", "1234", out token);
            loggedAirlineFacade = new LoggedAirlineFacade();
        }

        [ResponseType(typeof(Flight))]
        [HttpPost]
        [Route("api/Airline/CreateFlight", Name = "AddFlight")]
        public IHttpActionResult CreateFlight([FromBody] Flight f)
        {
            GetFacadeAndToken(out LoggedAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token);

            try 
            {
                loggedAirlineFacade.CreateFlight(token, f);
            }
            catch(Exception ex)
            {
                // return correct code -- see in anon facade controller
            }

            

            // replace with CreateAtRoute ....
            return Content(HttpStatusCode.Created, f);


        }
    }
}
