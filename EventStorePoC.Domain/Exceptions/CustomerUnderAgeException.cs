using System.Runtime.Serialization;

namespace EventStorePoC.Domain.ValueObjects
{
    [Serializable]
    internal class CustomerUnderAgeException : Exception
    {
        public CustomerUnderAgeException() : base("Customer should be at least 18 years old.")
        {

        }
    }
}