using Application.DTOs;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Employee
{
    public class GetAllEmployeesPresenter :
        IGetAllEmployeesOutputPort, IPresenter<IEnumerable<EmployeeDTO>>
    {
        public IEnumerable<EmployeeDTO> Content { get; private set; }

        public Task Handle(IEnumerable<EmployeeDTO> employees)
        {
            Content = employees;
            return Task.CompletedTask;
        }
    }
}
