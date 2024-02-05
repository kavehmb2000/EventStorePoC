using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Domain.ValueObjects;
public class CustomerDateOfBirthFormatException : CustomerException
{
    public CustomerDateOfBirthFormatException(string s) : base("Provided date of birth is not in a valid format. 'yyyy-MM-dd' is an acceptable format")
    {
    }
}