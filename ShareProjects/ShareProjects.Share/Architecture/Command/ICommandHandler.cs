using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShareProjects.Share.Architecture.Command
{
    public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand<TResult>
    {
        Task<ActionResult<TResult>> HandleAsync(TCommand command, CancellationToken token = default);
    }
}
