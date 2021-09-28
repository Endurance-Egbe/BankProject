using Bank.Domain;
using Bank.Domain.Models.Branch;
using ShareProjects.Share.Architecture.Command;
using ShareProjects.Share.Database;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bank.Application.Commands.BankBranchCommands
{
    public class CreateBankBranchCommandHandler : CommandHandler<CreateBankBranchCommand, CommandAccessory<BankContext>, Guid>
    {
        public override async Task<ActionResult<Guid>> HandleAsync(CreateBankBranchCommand command, CancellationToken token = default)
        {
            var fetchBankBranch = await DbContext.Store.BankBranchRepository.Exist(command.Email);
            
            if (fetchBankBranch)
                return FailedOperation($"Bank branch with the name {command.Name} already exist");

            var bankBranch = new BankBranchBuilder()
                .SetName(command.Name)
                .SetEmail(command.Email)
                .SetDescription(command.Description)
                .SetAddress(command.Address)
                .SetCountry(command.Country)
                .Build();

            DbContext.Store.BankBranchRepository.Add(bankBranch);
            var databaseCommit = await CommitToDatabaseAsync();

            if (databaseCommit.NotSuccesful)
                return FailedOperation("Unable to Persist to the data base");

            return SuccessfulOperation(bankBranch.Id);
        }
    }
}
