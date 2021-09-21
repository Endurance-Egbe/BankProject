using Bank.Domain.Models.Individual;
using NHibernate.Configuration.Repositories;

namespace Bank.Domain.Repository
{
    public interface IIndividualCustomerRepository : IRepository<IndividualCustomer>
    {
    }
}
