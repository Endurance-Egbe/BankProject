using System;

namespace Bank.Domain.Models.Individual
{
    public class IndividualCustomer : BaseEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
        public virtual string StateOfOrigin { get; set; }
        public virtual string Country { get; set; }
        public virtual DateTime DateOfRegistration { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual float Payment { get; set; }
        public virtual DateTime DateOfPayment { get; set; }
        public virtual float Balance { get; set; }
        public virtual IndividualAccount Account { get; set; }
    }
}
