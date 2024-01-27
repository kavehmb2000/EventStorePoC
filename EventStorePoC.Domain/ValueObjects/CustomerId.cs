using EventStorePoC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.ValueObjects
{
    public record CustomerId
    {
        public Guid Val { get; }
        public CustomerId(Guid v)
        {
            if (v == Guid.Empty) throw new CustomerIdException();
            Val = v;
        }
        public static implicit operator Guid(CustomerId vid) => vid.Val;
        public static implicit operator CustomerId(Guid id) => new(id);
    }
}
