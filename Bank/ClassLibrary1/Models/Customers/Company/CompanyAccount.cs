using ShareProjects.Share.Utilities;

namespace Bank.Domain.Models.Company
{
    public class CompanyAccount : BaseEntity
    {
        public virtual AccountType AccountType { get; set; }
    }
}