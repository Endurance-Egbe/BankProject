namespace Bank.Domain.Models.Individual
{
    public class IndividualAccount : BaseEntity
    {
        public virtual IndividualCustomer IndividualCustomer { get; set; }
        public virtual AccountType AccountType { get; set; }
    }
}