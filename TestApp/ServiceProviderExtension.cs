using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TestApp.BusinessLogicLayer.AutoMapper;
using TestApp.BusinessLogicLayer.Services.Implementation;
using TestApp.BusinessLogicLayer.Services.Interfaces;
using TestApp.DataAccessLayer.Repositories.Implemetation;
using TestApp.DataAccessLayer.Repositories.Interfaces;
using TestApp.DataAccessLayer.UnitOfWork.Implementation;
using TestApp.DataAccessLayer.UnitOfWork.Interfaces;
using TestApp.PresentationLayer.Mapper;

namespace TestApp.PresentationLayer
{
    public static  class ServiceProviderExtension
    {
        public static void AddUnitOfWorkAndRepository(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }

        public static void AddMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(c => {
                c.AddProfile<AddressModelProfile>();
                c.AddProfile<AreasModelProfile>();
                c.AddProfile<ContactInfoModelProfile>();
                c.AddProfile<ContactInfoViewModelProfile>();
                c.AddProfile<PasswordModelProfile>();
            });
            services.AddTransient<IMapper>(s => config.CreateMapper());
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        }
        //<TSource, TModel> where TSource : class where TModel : class
    }
}
