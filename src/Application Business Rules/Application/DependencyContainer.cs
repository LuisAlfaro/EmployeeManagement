using Application.UseCases.EmployeeShopUseCases.AssignEmployeeShop;
using Application.UseCases.EmployeeTypeUseCases.GeAllEmployeeTypes;
using Application.UseCases.EmployeeUseCases.CreateEmployee;
using Application.UseCases.EmployeeUseCases.DeleteEmployee;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using Application.UseCases.EmployeeUseCases.GetEmployeeById;
using Application.UseCases.EmployeeUseCases.UpdateEmployee;
using Application.UseCases.ShopUseCases.GeAllShops;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAplicatioServices(
            this IServiceCollection services
            )
        {
            services.AddTransient<ICreateEmployeeInputPort, CreateEmployeeInteractor>();
            services.AddTransient<IUpdateEmployeeInputPort, UpdatedEmployeeInteractor>();
            services.AddTransient<IDeleteEmployeeInputPort, DeleteEmployeeInteractor>();
            services.AddTransient<IGetAllEmployeesInputPort, GetAllEmployeesInteractor>();
            services.AddTransient<IGetEmployeeByIdInputPort, GetEmployeeByIdInteractor>();

            services.AddTransient<IGetAllEmployeeTypesInputPort, GeAllEmployeeTypesInteractor>();

            services.AddTransient<IGeAllShopsInputPort, GeAllShopsInteractor>();

            services.AddTransient<IAssignEmployeeShopInputPort, AssignEmployeeShopInteractor>();

            return services;
        }
    }
}
