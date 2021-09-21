using NHibernate;
using NHibernate.Configuration.Repositories;
using NHibernate.Linq;
using ShareProjects.Share.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareProjects.Share.Repositories
{
    public class Repository<T> : IRepository<T> where T: BaseEntity
    {
        public ISession Session { get; }

        public Repository(ISession session)
        {
            Session = session;
        }
        public void Update(T entity)
        {
            Session.SaveOrUpdate(entity);
        }

        public void Remove(T entity)
        {
            Session.Delete(entity);
        }

        public async Task<ActionResult<T>> FetchById(Guid id)
        {
            var entity = Session.Query<T>().FirstOrDefault(entity => entity.Id == id);

            if (entity == null)
                return ActionResult<T>.Failed().AddError($"No Entity found with Id {id}");

            return await Task.FromResult(ActionResult<T>.Success(entity));
        }

        public async Task<IEnumerable<T>> FetchAll()
        {
            return await Session.Query<T>().ToListAsync();
        }

        public void Add(T entity)
        {
            Session.Save(entity);
        }
    }
}
