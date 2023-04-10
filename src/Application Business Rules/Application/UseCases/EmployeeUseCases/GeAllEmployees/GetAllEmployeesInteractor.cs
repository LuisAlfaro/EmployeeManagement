using Application.DTOs;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeUseCases.GeAllEmployees
{
    public class GetAllEmployeesInteractor : IGetAllEmployeesInputPort
    {
        readonly IEmployeeRepository EmployeeRepository;
        readonly IGetAllEmployeesOutputPort OutputPort;

        public GetAllEmployeesInteractor(IEmployeeRepository employeeRepository,
            IGetAllEmployeesOutputPort outputPort) =>
            (EmployeeRepository, OutputPort) = (employeeRepository, outputPort);

        public Task Handle()
        {
            var employees = EmployeeRepository.GetEmployees().Select(employee =>
            new EmployeeDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                Type = employee.IdType,
                Telephone = employee.Telephone,
                Address = employee.Address,
                EmploymentDate = employee.EmploymentDate,
            }
            );
            OutputPort.Handle(employees);
            return Task.CompletedTask;
        }
    }
}
