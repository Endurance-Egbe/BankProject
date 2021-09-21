using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareProjects.Share.Architecture.Command
{
    public abstract class Command<TResult> : Command, ICommand<TResult>
    {
    }
    public abstract class Command
    {
        public abstract ActionResult Validation();
    }
}
