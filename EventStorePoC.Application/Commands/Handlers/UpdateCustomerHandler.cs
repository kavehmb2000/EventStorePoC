using EventStorePoC.Domain.Exceptions;
using EventStorePoC.Domain.Repositories;
using EventStorePoC.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Application.Commands.Handlers;

internal sealed class UpdateCustomerHandler : ICommandHandler<UpdateCustomer>
{
    private readonly ICustomerRepository _repository;
    public UpdateCustomerHandler(ICustomerRepository repository)
        => _repository = repository;


    public async Task HandlerAsync(UpdateCustomer command)
    {
        var customer = await _repository.GetByIdAsync(command.c.Id);
        if (customer == null)
        {
            throw new NullCustomerException(command.c.Id);
        }
        else
        {
            customer = command.c;
            await _repository.UpdateAsync(customer);
        }
    }
}
