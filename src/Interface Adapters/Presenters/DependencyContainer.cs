using Application.UseCases.EmployeeShopUseCases.AssignEmployeeShop;
using Application.UseCases.EmployeeTypeUseCases.GeAllEmployeeTypes;
using Application.UseCases.EmployeeUseCases.CreateEmployee;
using Application.UseCases.EmployeeUseCases.DeleteEmployee;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using Application.UseCases.EmployeeUseCases.GetEmployeeById;
using Application.UseCases.EmployeeUseCases.UpdateEmployee;
using Application.UseCases.ShopUseCases.GeAllShops;
using Microsoft.Extensions.DependencyInjection;
using Presenters.Employee;
using Presenters.EmployeeShop;

namespace Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentersServices(
            this IServiceCollection services
            )
        {
            services.AddScoped<ICreateEmployeeOutputPort, CreateEmployeePresenter>();
            services.AddScoped<IUpdateEmployeeOutputPort, UpdateEmployeePresenter>();
            services.AddScoped<IDeleteEmployeeOutputPort, DeleteEmployeePresenter>();
            services.AddScoped<IGetAllEmployeesOutputPort, GetAllEmployeesPresenter>();
            services.AddScoped<IGetEmployeeByIdOutputPort, GetEmployeeByIdPresenter>();

            services.AddScoped<IGetAllEmployeeTypesOutputPort, GetAllEmployeeTypesPresenter>();

            services.AddScoped<IGeAllShopsOutputPort, GetAllShopsPresenter>();

            services.AddScoped<IAssignEmployeeShopOutputPort, AssingEmployeeShopPresenter>();
            return services;
        }
    }
}
