using Bank.Domain.Models.Company;
using NHibernate.Configuration.Repositories;

namespace Bank.Domain.Repository
{
    public interface ICompanyCustomerRepository : IRepository<CompanyCustomer>
    {

    }
}
