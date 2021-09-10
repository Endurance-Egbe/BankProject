using Bank.Domain.Models.Individual;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate.Mappings
{
    public class IndividualCustomerMapping: ClassMap<IndividualCustomer>
    {
        public IndividualCustomerMapping()
        {
            Table("IndividualCustomer");
            Id(individual => individual.Id).GeneratedBy.GuidComb();
            Map(individual => individual.FirstName);
            Map(individual => individual.LastName);
            Map(individual => individual.Email);
            Map(individual => individual.DateOfBirth);
            Map(individual => individual.StateOfOrigin);
            Map(individual => individual.Country);
            Map(individual => individual.DateOfPayment);
            Map(individual => individual.DateOfRegistration);
            Map(individual => individual.Address);
            Map(individual => individual.Balance);
            Map(individual => individual.Payment);
            References(individual => individual.Account);
        }
    }
}
