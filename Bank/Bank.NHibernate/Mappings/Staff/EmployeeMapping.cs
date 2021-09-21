using Bank.Domain.Models.Staff;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate.Mappings.Staff
{
    public class EmployeeMapping : ClassMap<Employee>
    {
        public EmployeeMapping()
        {
            Table("Employee");
            Id(employee => employee.Id).GeneratedBy.GuidComb();
            Map(employee => employee.FirstName).Not.Nullable();
            Map(employee => employee.LastName).Not.Nullable();
            Map(employee => employee.Email);
            Map(employee => employee.DateOfBirth);
            Map(employee => employee.DateOfRegistration);
            Map(employee => employee.DateOfTransaction);
            Map(employee => employee.Address);
            Map(employee => employee.AmountCredited);
            Map(employee => employee.AmountDebited);
            Map(employee => employee.Balance);
            Map(employee => employee.BankManager);
            Map(employee => employee.Admin);
            Map(employee => employee.Country);
            Map(employee => employee.StateOfOrigin);
            CompositeId().KeyReference(employee => employee.Account)
                         .KeyReference(employee => employee.BankBranch);
        }
    }
}
