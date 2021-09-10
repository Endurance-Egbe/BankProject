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
            Map(company => company.Name);
            Map(company => company.Email);
            Map(company => company.Address);
            Map(company => company.Country);
            Map(company => company.DateOfPayment);
            Map(company => company.DateOfRegistration);
            Map(company => company.Balance);
            Map(company => company.Payment);
            Map(company => company.Description);
            References(company => company.CompanyAccount);
        }
    }
}
