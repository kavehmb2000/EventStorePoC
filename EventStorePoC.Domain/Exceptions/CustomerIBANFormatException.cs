using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Domain.Exceptions
{
    public class CustomerIBANFormatException : CustomerException
    {
        public CustomerIBANFormatException() : base("Provided IBAN by customer is not valid.")
        {
        }
    }
}