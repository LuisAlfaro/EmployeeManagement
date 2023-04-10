using Application.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Application.UseCases.EmployeeUseCases.UpdateEmployee
{
    public class UpdatedEmployeeInteractor : IUpdateEmployeeInputPort
    {
        readonly IEmployeeRepository EmployeeRepository;
        readonly IUnitOfWork UnitOfWork;
        readonly IUpdateEmployeeOutputPort OutputPort;

        public UpdatedEmployeeInteractor(IEmployeeRepository employeeRepository,
            IUnitOfWork unitOfWork,
            IUpdateEmployeeOutputPort outputPort) =>
            (EmployeeRepository, UnitOfWork, OutputPort) =
            (employeeRepository, unitOfWork, outputPort);

        public async Task Handle(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                Id = employeeDTO.Id,
                Name = employeeDTO.Name,
                Telephone = employeeDTO.Telephone,
                IdType = employeeDTO.Type,
                Address = employeeDTO.Address,
                EmploymentDate = employeeDTO.EmploymentDate,
            };
            EmployeeRepository.UpdateEmployee(employee);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(
                new EmployeeDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Telephone = employee.Telephone,
                    Type = employee.IdType,
                    Address = employee.Address,
                    EmploymentDate = employee.EmploymentDate
                }
                );
        }
    }
}
