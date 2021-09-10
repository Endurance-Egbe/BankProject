using Bank.Domain.Models.Company;
using FluentNHibernate.Mapping;
using System;

namespace Bank.NHibernate.Mappings
{
    public class CompanyAccountMapping : ClassMap<CompanyAccount>
    {
        public CompanyAccountMapping()
        {
            Table("CompanyAccount");
            Id(company => company.Id).GeneratedBy.GuidComb();
            Map(company => company.AccountType).Unique();
            References(company => company.IndividualCustomer);
        }
    }
}
