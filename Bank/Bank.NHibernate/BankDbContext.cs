using Bank.Domain;
using Bank.NHibernate.Repositories;
using Microsoft.Extensions.Logging;
using NHibernate;
using NHibernate.Configuration.DatabasePipeline;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate
{
    public class BankDbContext : DatabasePipeline<BankContext>
    {
        public BankDbContext(BankContext store, ISession session, ILogger logger):base(session) 
        {
            Store = store;
            Logger = logger;
            Pipeline = "Bank DB";
            Store.BankBranchRepository = new BankBranchRepository(session);
            Store.EmployeeRepository = new EmployeeRepository(session);
            Store.CompanyCustomerRepository = new CompanyCustomerRepository(session);
            Store.IndividualCustomerRepository = new IndividualCustomerRepository(session);
        }
    }
}
