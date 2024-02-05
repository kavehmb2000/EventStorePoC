using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Domain.Exceptions;
public class CustomerNullDateOfBirthException : CustomerException
{
    public CustomerNullDateOfBirthException() : base("Customer date of birth canot be null or empty.")
    {

    }
}
