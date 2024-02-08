using EventStorePoC.Domain.Entities;
using EventStorePoC.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(Customer customer);
        Task<Customer> GetByIdAsync(CustomerId id);
        Task<Customer> GetByNameAsync(FirstName firstName, LastName lastName, DateOfBirth dob);
    }
}
