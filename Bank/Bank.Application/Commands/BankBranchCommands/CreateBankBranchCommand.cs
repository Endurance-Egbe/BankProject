using Bank.Domain.Models.Company;
using Bank.Domain.Models.Individual;
using Bank.Domain.Models.Staff;
using ShareProjects.Share.Architecture.Command;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Application.Commands.BankBranchCommands
{
    public class CreateBankBranchCommand : Command<Guid>
    {
        public override ActionResult Validation()
        {
            return new FluentValidator()
                 .IsValidText(Name, "Invalid name")
                 .IsValidEmail(Email, "Invalid email")
                 .IsValidText(Description, "Invalid description")
                 .IsValidText(Address, "Invalid address")
                 .IsValidText(Country, "Invalid count")
                 .IsValidCollection(IndividualCustomers, "invalid collections")
                 .IsValidCollection(CompanyCustomers, "invalid collections")
                 .IsValidCollection(Employees, "invalid collections")
                 .Result;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public List<IndividualCustomer> IndividualCustomers { get; set; }
        public List<CompanyCustomer> CompanyCustomers { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
