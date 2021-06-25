using System;
using System.Threading.Tasks;

namespace TestApp.DataAccessLayer.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        Task<int> SaveAsync();
    }
}
