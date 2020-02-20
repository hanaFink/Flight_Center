using System;
using System.Runtime.Serialization;

namespace Flight_Center.Facade
{
    [Serializable]
    internal class NotFlightException : Exception
    {
        private LoginToken<AirlineCompanie> token;

        public NotFlightException()
        {
        }

        public NotFlightException(LoginToken<AirlineCompanie> token)
        {
            this.token = token;
            Console.WriteLine($"Airline id = {token.User.ID} has no flights");
        }

        public NotFlightException(string message) : base(message)
        {
        }

        public NotFlightException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFlightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}