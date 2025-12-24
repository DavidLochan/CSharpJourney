using System;

namespace ExceptionHandling
{
    public class AgeNotValidException : Exception
    {
        public AgeNotValidException(string message) : base(message)
        {
        }
    }
}