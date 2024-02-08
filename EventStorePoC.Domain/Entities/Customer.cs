using EventStorePoC.Domain.ValueObjects;

namespace EventStorePoC.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public DateOfBirth DateOfBirth { get; set; }
        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Email Email { get; set; }
        public BankAccount BankAccountNumber { get; set; }
    }
}