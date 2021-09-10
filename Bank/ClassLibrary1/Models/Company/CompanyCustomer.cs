using System;

namespace Bank.Domain.Models.Company
{
    public class CompanyCustomer : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Description { get; set; }
        public virtual string Address { get; set; }
        public virtual string Country { get; set; }
        public virtual DateTime DateOfRegistration { get; set; }
        public virtual float Payment { get; set; }
        public virtual DateTime DateOfPayment { get; set; }
        public virtual float Balance { get; set; }
        public virtual CompanyAccount CompanyAccount { get; set; }
    }
}
