using Bank.Domain.Models.Branch;
using NHibernate.Configuration.Repositories;

namespace Bank.Domain.Repository
{
    public interface IBankBranchRepository : IRepository<BankBranch>
    {
    }
}
