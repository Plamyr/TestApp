using System.Threading.Tasks;

namespace TestApp.BusinessLogicLayer.Services.Interfaces
{
    public interface IBaseService<TSource> where TSource: class
    {
        public Task CreateEntity<TModel>(TModel entity) where TModel:class;
        Task SaveAsync();
    }
}
