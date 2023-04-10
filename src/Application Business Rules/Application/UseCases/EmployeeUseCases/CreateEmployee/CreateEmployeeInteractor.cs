using Application.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Application.UseCases.EmployeeUseCases.CreateEmployee
{
    public class CreateEmployeeInteractor : ICreateEmployeeInputPort
    {
        readonly IEmployeeRepository EmployeeRepository;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreateEmployeeOutputPort OutputPort;

        public CreateEmployeeInteractor(IEmployeeRepository employeeRepository,
            IUnitOfWork unitOfWork,
            ICreateEmployeeOutputPort outputPort) =>
            (EmployeeRepository, UnitOfWork, OutputPort) =
            (employeeRepository, unitOfWork, outputPort);

        public async Task Handle(CreateEmployeeDTO createEmployee)
        {
            Employee newEmployee = new Employee
            {
                Name = createEmployee.Name,
                Telephone = createEmployee.Telephone,
                IdType = createEmployee.Type,
                Address = createEmployee.Address,
                EmploymentDate = createEmployee.EmploymentDate,
            };
            EmployeeRepository.CreateEmployee(newEmployee);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(
                new EmployeeDTO
                {
                    Id = newEmployee.Id,
                    Name = newEmployee.Name,
                    Telephone = newEmployee.Telephone,
                    Type = newEmployee.IdType,
                    Address = newEmployee.Address,
                    EmploymentDate = newEmployee.EmploymentDate
                }
                );
        }
    }
}
