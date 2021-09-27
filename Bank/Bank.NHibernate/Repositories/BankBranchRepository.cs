using Bank.Domain.Models.Branch;
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
    public class BankBranchRepository : Repository<BankBranch>, IBankBranchRepository
    {
        public BankBranchRepository(ISession session):base(session) { }

        public Task<ActionResult<BankBranch>> FetchByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
