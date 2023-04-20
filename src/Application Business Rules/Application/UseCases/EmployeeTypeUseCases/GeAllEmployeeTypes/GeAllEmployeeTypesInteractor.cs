using Application.DTOs;
using Application.UseCases.EmployeeUseCases.GeAllEmployees;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeTypeUseCases.GeAllEmployeeTypes
{
    public class GeAllEmployeeTypesInteractor : IGetAllEmployeeTypesInputPort
    {
        readonly IEmployeeTypeRepository EmployeeTypeRepository;
        readonly IGetAllEmployeeTypesOutputPort OutputPort;

        public GeAllEmployeeTypesInteractor(IEmployeeTypeRepository employeeTypeRepository,
            IGetAllEmployeeTypesOutputPort outputPort) =>
            (EmployeeTypeRepository, OutputPort) = (employeeTypeRepository, outputPort);

        public Task Handle()
        {
            var employeeTypes = EmployeeTypeRepository.GetEmployeeTypes().Select(employeeType =>
            new EmployeeTypeDTO
            {
                Id = employeeType.Id,
                Name = employeeType.Name,
                Salary = employeeType.Salary,
            }
            );
            OutputPort.Handle(employeeTypes);
            return Task.CompletedTask;
        }
    }
}
