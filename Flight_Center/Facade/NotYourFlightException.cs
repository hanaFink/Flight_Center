using System;
using System.Runtime.Serialization;

namespace Flight_Center.Facade
{
    [Serializable]
    internal class NotYourFlightException : Exception
    {
        public NotYourFlightException(LoginToken<AirlineCompanie> token)
        {
            Console.WriteLine($"Airlinecompany id = {token.User.ID}, don't have permition to do this action" );
        }

        public NotYourFlightException(string message) : base(message)
        {
        }

        public NotYourFlightException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotYourFlightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}