using Bank.Domain.Models.Company;
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
    public class CompanyCustomerRepository : Repository<CompanyCustomer>, ICompanyCustomerRepository
    {
        public CompanyCustomerRepository(ISession session): base(session) { }
    }
}
