using EventStorePoC.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.Exceptions
{
    public class CustomerIdException :CustomerException
    {
        public CustomerIdException():base("Customer Id cannot be empty.")
        {

        }
    }
}
