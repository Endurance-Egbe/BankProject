using Bank.Domain.Models.Branch;
using ShareProjects.Share.Utilities;
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
        public virtual float AmountCredited { get; set; }
        public virtual float AmountDebited { get; set; }
        public virtual DateTime DateOfTransaction { get; set; }
        public virtual float Balance { get; set; }
        public virtual BankBranch BankBranch { get; set; }
        public virtual CompanyAccount CompanyAccount { get; set; }
    }
}
