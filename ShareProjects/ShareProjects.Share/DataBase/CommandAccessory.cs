//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShareProjects.Share.Utilities;
using System;
using System.Threading.Tasks;

namespace ShareProjects.Share.Database
{
    public abstract class CommandAccessory<T> : ICommandContext
    {
        public abstract Task<ActionResult> CommitToDatabaseAsync();
        public virtual T Store { get; set; }
        public ILogger Logger { get; protected set; }
    }
    public interface ICommandContext
    {
        public Task<ActionResult> CommitToDatabaseAsync();
    }
}
