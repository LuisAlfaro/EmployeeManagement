using Application.DTOs;
using Application.UseCases.EmployeeUseCases.CreateEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Employee
{
    public class CreateEmployeePresenter :
        ICreateEmployeeOutputPort, IPresenter<EmployeeDTO>
    {
        public EmployeeDTO Content { get; private set; }

        public Task Handle(EmployeeDTO employee)
        {
            Content = employee;
            return Task.CompletedTask;
        }
    }
}
