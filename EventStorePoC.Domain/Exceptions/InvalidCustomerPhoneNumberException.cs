using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Domain.Exceptions
{
    public class InvalidCustomerPhoneNumberException : CustomerException
    {
        public InvalidCustomerPhoneNumberException() : base("You must enter a valid mobile phone number.")
        {
        }
    }
}