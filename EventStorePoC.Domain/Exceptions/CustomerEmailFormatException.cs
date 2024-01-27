using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Domain.Exceptions
{

    public class CustomerEmailFormatException : CustomerException
    {
        public CustomerEmailFormatException() : base("Customer email format is not acceptable.")
        {

        }
    }
}
