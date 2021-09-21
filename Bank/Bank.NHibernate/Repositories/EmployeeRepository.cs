using Bank.Domain.Models.Staff;
using Bank.Domain.Repository;
using NHibernate;
using ShareProjects.Share.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.NHibernate.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ISession session) : base(session) { }
    }
}
