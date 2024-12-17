using System.Linq.Expressions;

namespace HealthTracker.Repository.Interfaces
{
    public interface IRepositoryBase
    {
        void Create<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        void Save<T>() where T : class;
        IQueryable<T> GetAll<T>() where T : class;
        IQueryable<T> Query<T>(Expression<Func<T,bool>> expression) where T : class;
    }
}
