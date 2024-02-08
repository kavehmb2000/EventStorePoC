using EventStorePoC.Domain.Exceptions;
using EventStorePoC.Domain.Repositories;
using EventStorePoC.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Application.Commands.Handlers;

internal sealed class AddCustomerHandler : ICommandHandler<AddCustomer>
{
    private readonly ICustomerRepository _repository;
    public AddCustomerHandler(ICustomerRepository repository) 
        =>  _repository = repository;
    

    public async Task HandlerAsync(AddCustomer command)
    {
        var customer = await _repository.GetByNameAsync(command.c.FirstName, command.c.LastName,command.c.DateOfBirth);
        if(customer != null)
        {
            throw new CustomerAlreadyExistsException(command.c.FirstName,command.c.LastName,command.c.DateOfBirth);
        }
        else 
        await _repository.AddAsync(customer);
    }
}

