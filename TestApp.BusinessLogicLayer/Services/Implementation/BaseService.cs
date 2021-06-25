using AutoMapper;
using System.Threading.Tasks;
using TestApp.BusinessLogicLayer.Services.Interfaces;
using TestApp.DataAccessLayer.Repositories.Interfaces;
using TestApp.DataAccessLayer.UnitOfWork.Interfaces;

namespace TestApp.BusinessLogicLayer.Services.Implementation
{
    public class BaseService<TSource> : IBaseService<TSource> where TSource : class
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<TSource> _repository;

        public BaseService(IMapper mapper, IUnitOfWork unitOfWork, IBaseRepository<TSource> repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public Task CreateEntity<TModel>(TModel model) where TModel : class
        {
            var entity = _mapper.Map<TSource>(model);
            _repository.AddAsync(entity);
            return SaveAsync();
        }

        public Task SaveAsync()
        {
            return _unitOfWork.SaveAsync();
        }
    }
}
