using EventStorePoC.Domain.ValueObjects;
using EventStorePoC.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.Exceptions;
public class CustomerAlreadyExistsException : CustomerException
{
    public FirstName CustomerFirstName { get; }
    public LastName CustomerLastName { get; }
    public DateOfBirth CustomerDateOfBirth { get; }

    public CustomerAlreadyExistsException(FirstName customerFirstName, LastName customerLastName, DateOfBirth customerDateOfBirth) : base($"Customer already exists: '{customerFirstName.Val}' '{customerLastName.Val}' with date of birth '{customerDateOfBirth.ToString()} already exists among customers")
    {
        CustomerFirstName = customerFirstName;
        CustomerLastName = customerLastName;
        CustomerDateOfBirth = customerDateOfBirth;
    }

}
