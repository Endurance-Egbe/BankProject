using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShareProjects.Share.Architecture.Query
{
    public interface IQueryHandler<TQuery,TResponse> where TQuery : IQuery<TResponse> 
    {
        Task<ActionResult<TResponse>> HandleAsync(TQuery query, CancellationToken token = default);
    }
}
