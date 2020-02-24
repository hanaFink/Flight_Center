using System;
using System.Runtime.Serialization;

namespace Flight_Center.Facade
{
    [Serializable]
    internal class FlightDoNotHaveVacancyTicketsExeption : Exception
    {
        private Flight flight;

        public FlightDoNotHaveVacancyTicketsExeption()
        {
        }

        public FlightDoNotHaveVacancyTicketsExeption(Flight flight)
        {
            this.flight = flight;
            Console.WriteLine($"Flight id = {flight.ID} don't have vacant tickets");
        }

        public FlightDoNotHaveVacancyTicketsExeption(string message) : base(message)
        {
        }

        public FlightDoNotHaveVacancyTicketsExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FlightDoNotHaveVacancyTicketsExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}