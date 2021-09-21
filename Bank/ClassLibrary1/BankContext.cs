using Bank.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain
{
    public class BankContext
    {
        public virtual ICompanyCustomerRepository CompanyCustomerRepository { get; set; }
        public virtual IIndividualCustomerRepository IndividualCustomerRepository { get; set; }
        public virtual IBankBranchRepository BankBranchRepository { get; set; }
        public virtual IEmployeeRepository EmployeeRepository { get; set; }
    }
}
