using ShareProjects.Share.Utilities;

namespace Bank.Domain.Models.Individual
{
    public class IndividualAccount : BaseEntity
    {
        public virtual AccountType AccountType { get; set; }
    }
}