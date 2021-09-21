using Microsoft.Extensions.Logging;
using ShareProjects.Share.Database;
using ShareProjects.Share.Utilities;
using System;
using System.Threading.Tasks;

namespace NHibernate.Configuration.DatabasePipeline
{
    public class DatabasePipeline<T> : CommandAccessory<T> 
    {
        public DatabasePipeline(ISession session)
        {
            Session = session;
        }
        public override async Task<ActionResult> CommitToDatabaseAsync()
        {
            Logger?.LogInformation($"Comitting changes in {Pipeline}");

            using (var transaction = Session.BeginTransaction())
            {
                try
                {
                    transaction.Commit();
                    await Task.CompletedTask;
                }
                catch (Exception ec)
                {
                    Logger?.LogWarning($"Committing changes in {Pipeline}", ec.InnerException.Message);
                    return ActionResult.Failed()
                        .AddError($"Unable to save changes in {Pipeline}")
                        .AddError(ec.Message);
                }
            }
            return ActionResult.Success();
        }
        public ISession Session { get; set; }
        public string Pipeline { get; set; }
    }
}
