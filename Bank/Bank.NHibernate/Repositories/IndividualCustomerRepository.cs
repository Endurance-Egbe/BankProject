using Bank.Domain.Models.Individual;
using Bank.Domain.Repository;
using NHibernate;
using ShareProjects.Share.Repositories;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.NHibernate.Repositories
{
    public class IndividualCustomerRepository : Repository<IndividualCustomer>, IIndividualCustomerRepository
    {
        public IndividualCustomerRepository(ISession session):base(session) { }
    }
}
