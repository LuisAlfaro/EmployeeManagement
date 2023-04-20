using DataAccessEF.Repositories;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessEF
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDataAccess(
            this IServiceCollection services,
            IConfiguration configuration
            )
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DataAccessConnectionString")
                ));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeTypeRepository, EmployeeTypeRepository>();
            services.AddScoped<IEmployeeShopRepository, EmployeeShopRepository>();
            services.AddScoped<IShopRepository, ShopRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
