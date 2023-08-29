using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TechnicalTask.Data;
using TechnicalTask.Interfaces;

namespace TechnicalTask.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ApplicationDbContext Context;
        public Repository(ApplicationDbContext context)
        {
            Context = context;
        }
        public async Task AddAsync(TEntity entity) =>
     await Context.Set<TEntity>().AddAsync(entity);

        public async Task<TEntity> GetAsync(int id) =>
       await Context.Set<TEntity>().FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await Context.Set<TEntity>().ToListAsync();
        public async Task<TEntity> Exists(Expression<Func<TEntity, bool>> predicate) =>
            await Context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(predicate);
       
    }
}
