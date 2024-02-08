using EventStorePoC.Domain.Entities;
using EventStorePoC.Shared.Abstractions.Commands;

namespace EventStorePoC.Application.Commands;

public record AddCustomer(Customer c) : ICommand;

