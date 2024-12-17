using HealthTracker.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HealthTracker.Repository
{
    public class RepositoryBase : IRepositoryBase
    {
        protected readonly RepositoryContext repositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }

        public void Create<T>(T entity) where T : class
        {
            repositoryContext.Set<T>().Add(entity);
            Save<T>();
        }

        public void Remove<T>(T entity) where T : class
        {
            repositoryContext.Remove<T>(entity);
            Save<T>();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return repositoryContext.Set<T>().AsNoTracking(); 
        }

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return repositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Save<T>() where T : class
        {
            repositoryContext.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            repositoryContext.Update<T>(entity);
            Save<T>();
        }
    }
}
