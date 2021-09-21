using Bank.Domain.Models.Branch;
using Bank.Domain.Repository;
using NHibernate;
using ShareProjects.Share.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate.Repositories
{
    public class BankBranchRepository : Repository<BankBranch>, IBankBranchRepository
    {
        public BankBranchRepository(ISession session):base(session) { }
    }
}
