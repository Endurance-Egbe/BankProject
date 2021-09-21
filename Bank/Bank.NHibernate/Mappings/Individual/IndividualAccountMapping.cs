using Bank.Domain.Models.Individual;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate.Mappings
{
    public class IndividualAccountMapping: ClassMap<IndividualAccount>
    {
        public IndividualAccountMapping()
        {
            Table("IndividualAccount");
            Id(individual => individual.Id).GeneratedBy.GuidComb();
            Map(individual => individual.AccountType).Unique();
        }
    }
}
