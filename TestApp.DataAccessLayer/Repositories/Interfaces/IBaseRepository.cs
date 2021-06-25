using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.DataAccessLayer.Repositories.Interfaces
{
    public interface IBaseRepository<TSource> where TSource : class
    {
        Task AddAsync(TSource item);
        Task AddRangeAsync(IEnumerable<TSource> items);

        ValueTask<TSource> ReadAsync(int id);
        IEnumerable<TSource> ReadAll(Func<TSource, bool> predicate);
        IEnumerable<TSource> ReadAll();

        void Update(TSource item);
        void UpdateRange(IEnumerable<TSource> items);

        void Delete(TSource item);
        void DeleteRange(IEnumerable<TSource> items);
    }
}
