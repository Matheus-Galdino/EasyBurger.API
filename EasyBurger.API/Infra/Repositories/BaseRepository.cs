using EasyBurger.API.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EasyBurger.API.Infra.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly ApiContext _context;

        protected BaseRepository(ApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();

        public async Task<T?> GetBy(Expression<Func<T, bool>> predicate) => await _context.Set<T>().FirstOrDefaultAsync(predicate);

        public async Task<T> Create(T model)
        {
            await _context.Set<T>().AddAsync(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public bool Delete(T model)
        {
            var result = _context.Set<T>().Remove(model);

            return result.State == EntityState.Deleted;
        }
    }
}
