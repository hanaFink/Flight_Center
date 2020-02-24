using System;
using System.Runtime.Serialization;

namespace Flight_Center.Facade
{
    [Serializable]
    internal class NotCustomerFlightExeption : Exception
    {
        private Ticket ticket;

        public NotCustomerFlightExeption()
        {
        }

        public NotCustomerFlightExeption(Ticket ticket)
        {
            this.ticket = ticket;
            Console.WriteLine($"Customer id = {ticket.CUSTOMER_ID} you can't cancel flight id = {ticket.FLIGHT_ID} because you didn't buy a ticket for this flight"  );
        }

        public NotCustomerFlightExeption(string message) : base(message)
        {
        }

        public NotCustomerFlightExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotCustomerFlightExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}