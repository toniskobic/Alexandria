using System.Linq.Expressions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetAsync(int id);

        TEntity Add(TEntity entity);

        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match);

        Task<TEntity> UpdateAsync(TEntity updated, int key);

        void Delete(TEntity entity);
    }
}
