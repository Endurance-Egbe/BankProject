using Bank.Domain.Models.Company;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate.Mappings
{
    public class CompanyCustomerMapping: ClassMap<CompanyCustomer>
    {
        public CompanyCustomerMapping()
        {
            Table("CompanyCustomer");
            Id(company => company.Id).GeneratedBy.GuidComb();
            Map(company => company.Name).Not.Nullable();
            Map(company => company.Email);
            Map(company => company.Address);
            Map(company => company.Country);
            Map(company => company.DateOfTransaction);
            Map(company => company.DateOfRegistration);
            Map(company => company.Balance);
            Map(company => company.AmountCredited);
            Map(company => company.AmountDebited);
            Map(company => company.Description);
            CompositeId().KeyReference(company => company.CompanyAccount)
                         .KeyReference(company => company.BankBranch);
        }
    }
}
