using ApiFlight_Center.Models;
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
    public class AnonymousFacadeController : ApiController
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

            Flight f = null;

            try
            {
                f = anonFacade.GetFlightById(id);

                // if flight not found
                if (f == null)
                    return Content(HttpStatusCode.NoContent, $"Flight with id {id} not found!");
            }
            // custom exceptions ...

            // general exception ...
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex); // server side error
            }

            return Ok(f);
        }
    }
}
