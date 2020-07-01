using ApiFlight_Center.BasicAuth;
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
    //[BasicAuthCompany]
    public class CompanyFacadeApiController : ApiController
    {

        // temporary code ... will be replaced !!!!!!!!!!!!!!!!!1
        private void GetFacadeAndToken(out LoggedInAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token)
        {
            LoginService loginService = new LoginService();

            loginService.TryAirlineLogin("elal", "1234", out loggedAirlineFacade, out token);
            loggedAirlineFacade = new LoggedInAirlineFacade();
        }

        // NEW method
        //private void GetFacadeAndToken(out LoggedInAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token)
        //{ 
        //    token = Request.Properties["airline_token"] as LoginToken<AirlineCompanie>;
        //    loggedAirlineFacade = Request.Properties["facade"] as LoggedInAirlineFacade;
        //}

        [ResponseType(typeof(Ticket))]
        [HttpGet]
        [Route("api/Airline/GetAllTickets", Name = "GetAllTickets")]
        public IHttpActionResult GetAllTickets()
        {
            GetFacadeAndToken(out LoggedInAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token);

            IList<Ticket> listOfTickets = null;

            try
            {
              listOfTickets =   loggedAirlineFacade.GetAllTickets(token);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(listOfTickets);

        }

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Airline/GetAllFlights", Name = "GetAllCompanyFlights")]
        public IHttpActionResult GetAllFlights()
        {
            GetFacadeAndToken(out LoggedInAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token);

            IList<Flight> listOfFlights = null;

            try
            {
                listOfFlights = loggedAirlineFacade.GetAllFlights(token);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(listOfFlights);
        }


        [ResponseType(typeof(Flight))]
        [HttpPost]
        [Route("api/Airline/CreateFlight", Name = "AddFlight")]
        public IHttpActionResult CreateFlight([FromBody] Flight flight)
        {
            GetFacadeAndToken(out LoggedInAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token);

            try 
            {
                loggedAirlineFacade.CreateFlight(token, flight);
            }
            catch(Exception ex)
            {
                // return correct code -- see in anon facade controller
            }

            

            // replace with CreateAtRoute ....
            return Content(HttpStatusCode.Created, flight);


        }


        [ResponseType(typeof(Flight))]
        [HttpDelete]
        [Route("api/Airline/CancelFlight/{flight}", Name = "CancelFlight")]
        public IHttpActionResult CancelFlight([FromBody] Flight flight)
        {
            GetFacadeAndToken(out LoggedInAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token);

            try
            {
                loggedAirlineFacade.CancelFlight(token, flight);
            }
            catch (Exception ex)
            {
                // return correct code -- see in anon facade controller
            }



            // replace with CreateAtRoute ....
            return Content(HttpStatusCode.Created, flight);


        }

        [ResponseType(typeof(Flight))]
        [HttpPut]
        [Route("api/Airline/UpdateFlight/{flight}", Name = "UpdateFlight")]
        public IHttpActionResult UpdateFlight([FromBody] Flight flight)
        {
            GetFacadeAndToken(out LoggedInAirlineFacade loggedAirlineFacade, out LoginToken<AirlineCompanie> token);

            try
            {
                loggedAirlineFacade.UpdateFlight(token, flight);
            }
            catch (Exception ex)
            {
                // return correct code -- see in anon facade controller
            }



            // replace with CreateAtRoute ....
            return Content(HttpStatusCode.Created, flight);


        }


    }
}
