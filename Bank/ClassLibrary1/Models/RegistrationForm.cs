using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Models
{
    public class RegistrationForm : BaseEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
        public virtual string StateOfOrigin { get; set; }
        public virtual string Country { get; set; }
        public virtual DateTime DateOfRegistration { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual float AmountCredited { get; set; }
        public virtual float AmountDebited { get; set; }
        public virtual DateTime DateOfTransaction { get; set; }
        public virtual float Balance { get; set; }
    }
}
