using EventStorePoC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.ValueObjects
{
    public record BankAccount
    {
        public string Val { get; }
        public BankAccount(string iban)
        {
            //if (iban == string.Empty) throw new CustomerNullIBANException(); //suppose the user can add BankAccount later
            string pattern = @"^([a-zA-Z]{2}[0-9]{2}[a-zA-Z0-9]{4}[0-9]{7}([a-zA-Z0-9]?){0,16})$";
            if (!Regex.IsMatch(iban.Trim(), pattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) throw new CustomerIBANFormatException();
            else
                Val = iban.Trim();
        }
        public static implicit operator string(BankAccount iban) => iban.Val;
        public static implicit operator BankAccount(string iban) => new(iban);
    }
}
