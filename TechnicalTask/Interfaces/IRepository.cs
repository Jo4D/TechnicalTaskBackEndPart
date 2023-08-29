using System.Linq.Expressions;
using TechnicalTask.Data;

namespace TechnicalTask.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> Exists(Expression<Func<TEntity, bool>> func);
    }
}
