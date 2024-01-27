using EventStorePoC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.ValueObjects
{
    public record FirstName
    {
        public string Val { get; }
        public FirstName(string v)
        {
            if (v == string.Empty) throw new CustomerNameException();
            Val = v.Trim();
        }
        public static implicit operator string(FirstName name) => name.Val;
        public static implicit operator FirstName(string name) => new(name);
    }
}
