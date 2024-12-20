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

        public async Task Create<T>(T entity) where T : class
        {
            await repositoryContext.Set<T>().AddAsync(entity);
            await Save<T>();
        }

        public async Task Remove<T>(T entity) where T : class
        {
            repositoryContext.Remove<T>(entity);
            await Save<T>();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return repositoryContext.Set<T>().AsNoTracking(); 
        }

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return repositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task Save<T>() where T : class
        {
            await repositoryContext.SaveChangesAsync();
        }

        public async Task<bool> Exists<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return await repositoryContext.Set<T>().AnyAsync<T>(expression);
        }

        public async Task Update<T>(T entity) where T : class
        {
            repositoryContext.Update<T>(entity);
            await Save<T>();
        }
    }
}
