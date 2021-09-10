namespace Bank.Domain.Models.Company
{
    public class CompanyAccount : BaseEntity
    {
        public virtual CompanyCustomer IndividualCustomer { get; set; }
        public virtual AccountType AccountType { get; set; }
    }
}