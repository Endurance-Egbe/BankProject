using Bank.Domain.Models.Company;
using Bank.Domain.Models.Individual;
using Bank.Domain.Models.Staff;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Models.Branch
{
    public class BankBranch : BaseEntity
    {
        public virtual void AddIndividualCustomer(IndividualCustomer individualCustomer)
        {
            _individualCustomers.Add(individualCustomer);
        }
        public virtual void AddCompanyCustomer(CompanyCustomer companyCustomer)
        {
            _companyCustomers.Add(companyCustomer);
        }
        public virtual void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public virtual void RemoveIndividualCustomer(IndividualCustomer individualCustomer)
        {
            _individualCustomers?.Remove(individualCustomer);
        }
        public virtual void RemoveCompanyCustomer(CompanyCustomer companyCustomer)
        {
            _companyCustomers?.Remove(companyCustomer);
        }
        public virtual void RemoveEmployee(Employee employee)
        {
            _employees?.Remove(employee);
        }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Description { get; set; }
        public virtual string Address { get; set; }
        public virtual string Country { get; set; }
        public virtual IEnumerable<IndividualCustomer> IndividualCustomers => _individualCustomers;
        public virtual IEnumerable<CompanyCustomer> CompanyCustomers => _companyCustomers;
        public virtual IEnumerable<Employee> Employees => _employees;
        private ISet<IndividualCustomer> _individualCustomers = new HashSet<IndividualCustomer>();
        private ISet<CompanyCustomer> _companyCustomers = new HashSet<CompanyCustomer>();
        private ISet<Employee> _employees = new HashSet<Employee>();
    }
}
