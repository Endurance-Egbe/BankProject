using Bank.Domain.Models.Branch;
using NHibernate.Configuration.Repositories;
using ShareProjects.Share.Utilities;
using System.Threading.Tasks;

namespace Bank.Domain.Repository
{
    public interface IBankBranchRepository : IRepository<BankBranch>
    {
        Task<ActionResult<BankBranch>> FetchByEmail(string email);
    }
}
