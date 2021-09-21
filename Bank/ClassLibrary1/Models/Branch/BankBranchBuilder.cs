using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Models.Branch
{
    public class BankBranchBuilder
    {
        public BankBranchBuilder SetName(string name)
        {
            _name = name;
            return this;
        }
        public BankBranchBuilder SetEmail(string email)
        {
            _email = email;
            return this;
        }
        public BankBranchBuilder SetDescription(string description)
        {
            _description = description;
            return this;
        }
        public BankBranchBuilder SetAddress(string address)
        {
            _address = address;
            return this;
        }
        public BankBranch Build()
        {
            return new BankBranch
            {
                Name = _name,
                Email = _email,
                Description = _description,
                Address = _address
            };
        }
        private string _name;
        private string _email;
        private string _description;
        private string _address;
    }
}
