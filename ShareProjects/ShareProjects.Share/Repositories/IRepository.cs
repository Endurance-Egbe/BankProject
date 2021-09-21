using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NHibernate.Configuration.Repositories
{
    public interface IRepository<T> 
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task<ActionResult<T>> FetchById(Guid id);
        Task<IEnumerable<T>> FetchAll();
    }
}
