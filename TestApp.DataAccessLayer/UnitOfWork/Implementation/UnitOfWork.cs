using System;
using System.Threading.Tasks;
using TestApp.DataAccessLayer.Repositories.Interfaces;
using TestApp.DataAccessLayer.UnitOfWork.Interfaces;

namespace TestApp.DataAccessLayer.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork 
    {
        public TestAppContext DbContext { get; }

        public UnitOfWork(TestAppContext dbContext)
        {
            DbContext = dbContext;
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int Save()
        {
            return DbContext.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return DbContext.SaveChangesAsync();
        }
    }
}
