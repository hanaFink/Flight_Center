using System;
using System.Runtime.Serialization;

namespace Flight_Center
{
    [Serializable]
    internal class WrongPasswors : Exception
    {
        public WrongPasswors(string username)
        {
            Console.WriteLine($"User {username} enter  wrong password");
        }

        public WrongPasswors(string message,string username) : base(message)
        {
        }

        public WrongPasswors(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongPasswors(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}