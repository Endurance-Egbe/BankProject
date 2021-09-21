using Bank.Domain.Models.Branch;
using ShareProjects.Share.Utilities;
using System;

namespace Bank.Domain.Models.Individual
{
    public class IndividualCustomer : RegistrationForm
    {
        public virtual BankBranch BankBranch { get; set; }
        public virtual IndividualAccount Account { get; set; }
    }
}
