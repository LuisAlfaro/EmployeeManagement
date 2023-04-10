using Application.DTOs;

namespace Application.UseCases.EmployeeUseCases.CreateEmployee
{
    public interface ICreateEmployeeInputPort
    {
        Task Handle(CreateEmployeeDTO createEmployee);
    }
}
