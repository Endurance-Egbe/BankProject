using Bank.Domain;
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
        public override Task<ActionResult<Guid>> HandleAsync(CreateBankBranchCommand command, CancellationToken token = default)
        {
            var fetchBankBranch = DbContext.Store.BankBranchRepository.
        }
    }
}
