namespace EventStorePoC.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; }
        public string? BankAccountNumber { get; set; }
    }
}