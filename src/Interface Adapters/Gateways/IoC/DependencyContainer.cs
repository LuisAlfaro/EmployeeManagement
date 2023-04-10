using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application;
using DataAccessEF;
using Presenters;

namespace IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependencies(
            this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDataAccess(configuration);
            services.AddAplicatioServices();
            services.AddPresentersServices();
            return services;
        }
    }
}
