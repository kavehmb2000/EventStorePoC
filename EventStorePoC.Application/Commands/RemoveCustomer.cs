using EventStorePoC.Domain.Entities;
using EventStorePoC.Domain.ValueObjects;
using EventStorePoC.Shared.Abstractions.Commands;

namespace EventStorePoC.Application.Commands
{
    //public record RemoveCustomer(Customer c) : ICommand;
    public record RemoveCustomer(CustomerId Id) : ICommand;
}
