using Lucky.WebAPI.Data;
using Lucky.WebAPI.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Lucky.WebAPI.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly LuckyDbContext _luckyDbContext;

        public RepositoryBase(LuckyDbContext luckyDbContext)
        {
            _luckyDbContext = luckyDbContext;
        }
        public void Create(T entity)
        {
            _luckyDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _luckyDbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges ? _luckyDbContext.Set<T>().AsNoTracking() : _luckyDbContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges ? _luckyDbContext.Set<T>().Where(expression).AsNoTracking() : _luckyDbContext.Set<T>().Where(expression);
        }

        public void Update(T entity)
        {
            _luckyDbContext.Set<T>().Update(entity);
        }
    }
}
