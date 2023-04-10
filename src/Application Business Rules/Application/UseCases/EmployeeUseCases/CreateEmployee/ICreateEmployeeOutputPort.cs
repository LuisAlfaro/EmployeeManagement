using Application.DTOs;

namespace Application.UseCases.EmployeeUseCases.CreateEmployee
{
    public interface ICreateEmployeeOutputPort
    {
        Task Handle(EmployeeDTO employee);
    }
}
