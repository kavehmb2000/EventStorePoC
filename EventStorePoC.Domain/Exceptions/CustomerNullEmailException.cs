using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Domain.Exceptions
{
    public class CustomerNullEmailException : CustomerException
    {
        public CustomerNullEmailException() : base("Customer email canot be null or empty.")
        {

        }
    }
}