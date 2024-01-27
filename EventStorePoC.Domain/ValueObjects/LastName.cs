using EventStorePoC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.ValueObjects
{
    public record LastName
    {
        public string Val { get; }
        public LastName(string v)
        {
            if (v == string.Empty) throw new CustomerNameException();
            Val = v.Trim();
        }
        public static implicit operator string(LastName name) => name.Val;
        public static implicit operator LastName(string name) => new(name);
    }
}
