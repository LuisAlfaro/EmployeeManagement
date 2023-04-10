using Application.DTOs;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using Application.UseCases.EmployeeUseCases.GetEmployeeById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Employee
{
    public class GetEmployeeByIdPresenter :
        IGetEmployeeByIdOutputPort, IPresenter<EmployeeDTO>
    {
        public EmployeeDTO Content { get; private set; }

        public Task Handle(EmployeeDTO employee)
        {
            Content = employee;
            return Task.CompletedTask;
        }
    }
}
