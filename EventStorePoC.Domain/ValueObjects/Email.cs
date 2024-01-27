using EventStorePoC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.ValueObjects
{
    public record Email
    {
        public string Val { get; }
        public Email(string v)
        {
            if (v == string.Empty) throw new CustomerNullEmailException();
            string pattern = @"^([^@\s]+)@([^@\s]+)\.([^@\s]+)$";
            //Match match = regex.Match(v);
            if (!Regex.IsMatch(v, pattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) throw new CustomerEmailFormatException();
            else
                Val = v.Trim();
        }
        public static implicit operator string(Email emailAddress) => emailAddress.Val;
        public static implicit operator Email(string emailAddress) => new(emailAddress);
    }
}
