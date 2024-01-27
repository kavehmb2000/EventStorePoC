using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Domain.Exceptions
{
    public class CustomerNameException : CustomerException
    {
        public CustomerNameException(): base("Name cannot be null or empty.")
        {
        }
    }
}