using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using API.Errors;

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