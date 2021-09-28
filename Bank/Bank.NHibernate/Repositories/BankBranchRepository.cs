using Bank.Domain.Models.Branch;
using Bank.Domain.Repository;
using NHibernate;
using NHibernate.Linq;
using ShareProjects.Share.Repositories;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.NHibernate.Repositories
{
    public class BankBranchRepository : Repository<BankBranch>, IBankBranchRepository
    {
        public BankBranchRepository(ISession session):base(session) { }

        public async Task<ActionResult<BankBranch>> FetchByEmail(string email)
        {
            var bankBranch = Session.Query<BankBranch>().FirstOrDefault(bank => bank.Email == email);
            if (bankBranch==null)
                ActionResult.Failed().AddError($"Invalid bank branch with the Email {email}");

            return await Task.FromResult(ActionResult<BankBranch>.Success(bankBranch));
        }
        public async Task<bool> Exist(string name)
        {
            return await Session.Query<BankBranch>().AnyAsync(bank => bank.Name == name);
        }
    }
}
