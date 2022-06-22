using ECommerceDemo.Application.Abstractions;
using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Persistence.Concretes;
using ECommerceDemo.Persistence.Contexts;
using ECommerceDemo.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDemo.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceDemo.API"));
            configurationManager.AddJsonFile("appsettings.json");

            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<ECommerceDemoPostgresqlContext>(options => options.UseNpgsql(configurationManager.GetConnectionString("PostgreSql")));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        }
    }
}
