using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.DataAccessLayer.Repositories.Interfaces;

namespace TestApp.DataAccessLayer.Repositories.Implemetation
{
    public class BaseRepository<TSource> : IBaseRepository<TSource> where TSource : class
    {
        private readonly TestAppContext _context;
        private readonly DbSet<TSource> _set;

        public BaseRepository(TestAppContext context)
        {
            _context = context;
            _set = _context.Set<TSource>();
        }

        public Task AddAsync(TSource item)
        {
            return AddRangeAsync(new[] { item });
        }

        public Task AddRangeAsync(IEnumerable<TSource> items)
        {
            return _set.AddRangeAsync(items);
        }

        public async ValueTask<TSource> ReadAsync(int id)
        {
            var entity = await _set.FindAsync(id);
            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public IEnumerable<TSource> ReadAll(Func<TSource, bool> predicate)
        {

            return _set.AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<TSource> ReadAll()
        {
            return _set.AsNoTracking().ToList();
        }

        public void Update(TSource item)
        {
            UpdateRange(new[] { item });
        }

        public void UpdateRange(IEnumerable<TSource> items)
        {
            _context.UpdateRange(items);
        }

        public void Delete(TSource item)
        {
            DeleteRange(new[] { item });
        }

        public void DeleteRange(IEnumerable<TSource> items)
        {
            _context.RemoveRange(items);
        }
    }
}
