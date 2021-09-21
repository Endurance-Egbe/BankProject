using Bank.Domain.Models.Branch;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate.Mappings.Bank
{
    public class BankBranchMapping : ClassMap<BankBranch>
    {
        public BankBranchMapping()
        {
            Table("BankBranch");
            Id(bankBranch => bankBranch.Id).GeneratedBy.GuidComb();
            Map(bankBranch => bankBranch.Name).Not.Nullable();
            Map(bankBranch => bankBranch.Email);
            Map(bankBranch => bankBranch.Address);
            Map(bankBranch => bankBranch.Country);
            Map(bankBranch => bankBranch.Description);
            HasMany(bankBranch => bankBranch.IndividualCustomers).Cascade.All().Inverse().LazyLoad();
            HasMany(bankBranch => bankBranch.Employees).Cascade.All().Inverse().LazyLoad();
            HasMany(bankBranch => bankBranch.CompanyCustomers).Cascade.All().Inverse().LazyLoad();
        }
    }
}
