using System.Linq.Expressions;

namespace HealthTracker.Repository.Interfaces
{
    public interface IRepositoryBase
    {
        Task Create<T>(T entity) where T : class;
        Task Remove<T>(T entity) where T : class;
        Task Save<T>() where T : class;
        IQueryable<T> GetAll<T>() where T : class;
        Task<bool> Exists<T>(Expression<Func<T, bool>> expression) where T : class;
    }
}
