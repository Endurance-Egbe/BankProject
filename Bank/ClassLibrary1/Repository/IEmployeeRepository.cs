using Bank.Domain.Models.Staff;
using NHibernate.Configuration.Repositories;

namespace Bank.Domain.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}