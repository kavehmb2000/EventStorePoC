using EventStorePoC.Domain.Exceptions;
using PhoneNumbers;
//using PhoneNumbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.ValueObjects
{
    public record PhoneNumber
    {
        public string Val { get; }
        public PhoneNumber(string phoneNumber)
        {
            //if (phoneNumber == string.Empty) throw new CustomerNullPhoneNumberException(); //suppose the user can add the phone number later

            //phone number must be a mobile phone
            //ToDo: refactor: phoneNumberUtil should be a singleton and be placed on project initiation
            var _Util = PhoneNumberUtil.GetInstance();
            var p = _Util.Parse(phoneNumber,"NL"); //should find a way to accept intrnational ?phone number?
            if(!_Util.IsPossibleNumberForType(p, PhoneNumberType.MOBILE)) throw new InvalidCustomerPhoneNumberException();
            Val = _Util.Format(p,PhoneNumberFormat.INTERNATIONAL);
        }

        public static implicit operator string(PhoneNumber phoneNumber) => phoneNumber.Val;
        public static implicit operator PhoneNumber(string phoneNumber) => new(phoneNumber);
    }
}


