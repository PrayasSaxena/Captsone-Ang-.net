using Core.Interfaces;
using Infrastructure.Data;

namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
           services.AddScoped<IProductRepository, ProductRepository>();
           services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));   

            return services;
        }
    }
}