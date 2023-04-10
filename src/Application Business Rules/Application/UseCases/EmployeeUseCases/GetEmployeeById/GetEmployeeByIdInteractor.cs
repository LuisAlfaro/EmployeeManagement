using Application.DTOs;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeUseCases.GetEmployeeById
{
    public class GetEmployeeByIdInteractor : IGetEmployeeByIdInputPort
    {
        readonly IEmployeeRepository EmployeeRepository;
        readonly IGetEmployeeByIdOutputPort OutputPort;

        public GetEmployeeByIdInteractor(IEmployeeRepository employeeRepository,
            IGetEmployeeByIdOutputPort outputPort) =>
            (EmployeeRepository, OutputPort) = (employeeRepository, outputPort);

        public Task Handle(int Id)
        {
            var employee = EmployeeRepository.GetEmployee(Id);
            var employeeDTO = new EmployeeDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                Type = employee.IdType,
                Telephone = employee.Telephone,
                Address = employee.Address,
                EmploymentDate = employee.EmploymentDate,
            };

            OutputPort.Handle(employeeDTO);
            return Task.CompletedTask;
        }
    }
}
