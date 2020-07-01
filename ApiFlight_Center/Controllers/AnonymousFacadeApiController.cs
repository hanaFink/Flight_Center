
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Flight_Center;

namespace ApiFlight_Center.Controllers
{
    public class AnonymousFacadeApiController : ApiController
    {
        // all anonymous facade methods

        //get all flights

        private AnonymousUserFacade anonFacade = new AnonymousUserFacade();

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Anonymous/GetFlightById/{id}", Name = "GetById")]
        public IHttpActionResult GetFlightById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id must be positive number");
            }

            Flight FlightById = null;

            try
            {
                FlightById = anonFacade.GetFlightById(id);

                // if flight not found
                if (FlightById == null)
                    return Content(HttpStatusCode.NoContent, $"Flight with id {id} not found!");
            }
            // custom exceptions ...

            // general exception ...
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(FlightById);
        }

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Anonymous/GetAllFlights", Name = "GetAllFlights")]
        public IHttpActionResult GetAllFlights()
        {
         
            IList<Flight> ListOfFlights = null;
            try
            {
                ListOfFlights = anonFacade.GetAllFlights();

                // if flights not found
                if (ListOfFlights == null)
                    return Content(HttpStatusCode.NoContent, $"No flight was found!");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(ListOfFlights);
        }

        [ResponseType(typeof(AirlineCompanie))]
        [HttpGet]
        [Route("api/Anonymous/GetAllAirlineCompanies", Name = "GetAllAirlineCompanies")]
        public IHttpActionResult GetAllAirlineCompanies()
        {

            IList<AirlineCompanie> ListOfAirlineCompanies = null;
            try
            {

                ListOfAirlineCompanies = anonFacade.GetAllAirlineCompanies();

                // if AirlineCompanie not found
                if (ListOfAirlineCompanies == null)
                    return Content(HttpStatusCode.NoContent, $"No Airline was found!");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(ListOfAirlineCompanies);
        }

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Anonymous/GetAllFlightsVacancy", Name = "GetAllFlightsVacancy")]
        public IHttpActionResult GetAllFlightsVacancy()
        {

            Dictionary<Flight, int> ListOfFlights =null;
            try
            {
                ListOfFlights = anonFacade.GetAllFlightsVacancy();

                // if flights not found
                if (ListOfFlights == null)
                    return Content(HttpStatusCode.NoContent, $"No flight was found!");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(ListOfFlights);
        }

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Anonymous/GetFlightsByOriginCountry/{countryCode}", Name = "GetFlightsByOriginCountry")]
        public IHttpActionResult GetFlightsByOriginCountry(int countryCode)
        {

            IList<Flight> ListOfFlights = null;

            if (countryCode <= 0 & countryCode>=228)
            {
                return BadRequest(" This country code does not exist");
            }
            try
            {
                ListOfFlights = anonFacade.GetFlightsByOriginCountry(countryCode);

                // if flights not found
                if (ListOfFlights == null)
                    return Content(HttpStatusCode.NoContent, $"No flight was found!");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(ListOfFlights);
        }

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Anonymous/ GetFlightsByDestinationCountry/{countryCode}", Name = " GetFlightsByDestinationCountry")]
        public IHttpActionResult GetFlightsByDestinationCountry(int countryCode)
        {

            IList<Flight> ListOfFlights = null;

            if (countryCode <= 0 & countryCode >= 228)
            {
                return BadRequest(" This country code does not exist");
            }
            try
            {
                ListOfFlights = anonFacade.GetFlightsByDestinationCountry(countryCode);

                // if flights not found
                if (ListOfFlights == null)
                    return Content(HttpStatusCode.NoContent, $"No flight was found!");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(ListOfFlights);
        }

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Anonymous/  GetFlightsByLandingDate/{landingDate}", Name = "  GetFlightsByLandingDate")]
        public IHttpActionResult GetFlightsByLandingDate(DateTime landingDate)
        {

            IList<Flight> ListOfFlights = null;


           

            if (landingDate == DateTime.Today)//to add validation if correct format
            {
                return BadRequest(" The date does not valid");
            }
            try
            {
                ListOfFlights = anonFacade.GetFlightsByLandingDate(landingDate);

                // if flights not found
                if (ListOfFlights == null)
                    return Content(HttpStatusCode.NoContent, $"No flight was found!");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(ListOfFlights);
        }

        [ResponseType(typeof(Flight))]
        [HttpGet]
        [Route("api/Anonymous/GetFlightsByDepartureDate/{departureDate}", Name = "GetFlightsByDepartureDate")]
        public IHttpActionResult GetFlightsByDepartureDate(DateTime departureDate)
        {

            IList<Flight> ListOfFlights = null;




            if (departureDate == DateTime.Today)//to add validation if correct format
            {
                return BadRequest(" The date does not valid");
            }
            try
            {
                ListOfFlights = anonFacade.GetFlightsByDepartureDate(departureDate);

                // if flights not found
                if (ListOfFlights == null)
                    return Content(HttpStatusCode.NoContent, $"No flight was found!");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(ListOfFlights);
        }
    }
}
