using Bank.Domain.Models.Branch;
using Bank.Domain.Models.Individual;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Models.Staff
{
    public class Employee : RegistrationForm
    {
        public virtual bool BankManager { get; set; }
        public virtual bool Admin { get; set; }
        public virtual BankBranch BankBranch { get; set; }
        public virtual IndividualAccount Account { get; set; }
    }
}
