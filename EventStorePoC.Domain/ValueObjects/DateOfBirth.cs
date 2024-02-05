using EventStorePoC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventStorePoC.Domain.ValueObjects;

    public record DateOfBirth
    {
        public DateOnly Val { get; }
        public DateOfBirth(string v)
        {
            if (v == string.Empty) throw new CustomerNullDateOfBirthException();
            try {
                DateOnly dateV = DateOnly.Parse(v) ;
                if (dateV.AddYears(-18)>DateOnly.FromDateTime(DateTime.Now))
                    Val = dateV;
                else
                    throw new CustomerUnderAgeException();
            }
            catch(FormatException fe)
            {
                throw new CustomerDateOfBirthFormatException(v);
            }
                
            }
        public static implicit operator string(DateOfBirth dateOfBirth) => dateOfBirth.Val.ToString("yyyy-MM-dd");
        public static implicit operator DateOfBirth(string dateOfBirth) => new(dateOfBirth);
    }

