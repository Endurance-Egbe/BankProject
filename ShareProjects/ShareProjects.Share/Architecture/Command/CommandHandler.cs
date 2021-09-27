using ShareProjects.Share.Database;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShareProjects.Share.Architecture.Command
{
    public abstract class CommandHandler<TDbContext> : IAuditableNote
    {
        public virtual void AddLog<T>(string logMessage) where T : ChangeLog
        {

        }
        public TDbContext DbContext { get; set; }
    }
    public abstract class CommandHandler<TCommand, TDbContext> : CommandHandler<TDbContext>
         where TDbContext : class, ICommandContext
         where TCommand: Command
    {
        public abstract Task<ActionResult> HandleAsync(TCommand command, CancellationToken token = default);

        protected async Task<ActionResult> CommitToDatabaseAsync()
        {
            return await DbContext.CommitToDatabaseAsync();
        }
        protected ActionResult FailedOperation(string error)
        {
            return ActionResult.Failed()
                               .SetErrors(new List<string> { error });
        }
        protected ActionResult FailedOperation(IEnumerable<string> error)
        {
            return ActionResult.Failed()
                               .SetErrors(error);
        }
        protected ActionResult SuccessfulOperation()
        {
            return ActionResult.Success();
        }
    }

    public abstract class CommandHandler<TCommand, TDbContext, TResponse> : CommandHandler<TDbContext>,
        ICommandHandler<TCommand, TResponse>
        where TCommand: ICommand<TResponse>
        where TDbContext: class, ICommandContext
    {
        public abstract Task<ActionResult<TResponse>> HandleAsync(TCommand command, CancellationToken token = default);
        
        protected async Task<ActionResult> CommitToDatabaseAsync()
        {
            return await DbContext.CommitToDatabaseAsync();
        }
        protected ActionResult<TResponse> FailedOperation(string error)
        {
            return ActionResult<TResponse>.Failed()
                                          .SetErrors(new List<string> { error });
        }
        protected ActionResult<TResponse> FailedOperation(IEnumerable<string> error)
        {
            return ActionResult<TResponse>.Failed()
                                          .SetErrors( error );
        }
        protected ActionResult<TResponse> SuccessfulOperation(TResponse response)
        {
            return ActionResult<TResponse>.Success(response);
        }
    }

    public interface IAuditableNote
    {
        void AddLog<T>(string logMessage) where T : ChangeLog;
    }
    public abstract class ChangeLog
    {
        public ChangeLog(string email)
        {
            Initiator = email;
        }

        public virtual string Initiator { get; }
        public virtual DateTime TimeStamp { get; } = DateTime.UtcNow;
    }
}
