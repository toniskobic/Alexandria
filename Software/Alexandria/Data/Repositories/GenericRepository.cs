using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Data.Interfaces;

namespace Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected AppDbContext AppDbContext { get; set; }

        public GenericRepository(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return AppDbContext.Set<TEntity>();
        }

        public Task<TEntity> GetAsync(int id)
        {
            return AppDbContext.Set<TEntity>().FindAsync(id);
        }

        public TEntity Add(TEntity entity)
        {
            return AppDbContext.Set<TEntity>().Add(entity);
        }

        public Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match)
        {
            return AppDbContext.Set<TEntity>().SingleOrDefaultAsync(match);
        }

        async public Task<TEntity> UpdateAsync(TEntity updated, int key)
        {
            if (updated == null)
                return null;

            TEntity existing = await AppDbContext.Set<TEntity>().FindAsync(key);
            if (existing != null)
            {
                AppDbContext.Entry(existing).CurrentValues.SetValues(updated);
            }

            return existing;
        }

        public void Delete(TEntity entity)
        {
            AppDbContext.Set<TEntity>().Remove(entity);
        }
    }
}

