using System;
using System.Runtime.Serialization;

namespace Flight_Center.Facade
{
    [Serializable]
    internal class NotValidIdExeption : Exception
    {
        private LoginToken<AirlineCompanie> token;
        private AirlineCompanie airline;

        public NotValidIdExeption()
        {
            
        }

        public NotValidIdExeption(string message) : base(message)
        {

        }

        public NotValidIdExeption(LoginToken<AirlineCompanie> token, AirlineCompanie airline)
        {
            this.token = token;
            this.airline = airline;
            Console.WriteLine($"Airline id {token.User.ID} not match to id {airline.ID}");
        }

        public NotValidIdExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotValidIdExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}