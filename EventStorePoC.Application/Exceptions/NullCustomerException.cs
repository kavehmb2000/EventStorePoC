using EventStorePoC.Domain.ValueObjects;
using EventStorePoC.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace EventStorePoC.Application.Exceptions;


public class NullCustomerException : CustomerException
{

    public NullCustomerException(CustomerId cid ,FirstName customerFirstName, LastName customerLastName, DateOfBirth customerDateOfBirth) 
        : base($"Customer does not exists: '{customerFirstName.Val}' '{customerLastName.Val}' with date of birth '{customerDateOfBirth} ' and Id '{cid} ' does not exist among customers")
    {
    }
    public NullCustomerException(CustomerId cid)
        : base($"Customer does not exists: Customer with Id '{cid} ' does not exist among customers")
    {
    }

}