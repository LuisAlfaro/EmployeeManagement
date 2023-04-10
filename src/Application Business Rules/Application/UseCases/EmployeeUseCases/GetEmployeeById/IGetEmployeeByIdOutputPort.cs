using Application.DTOs;

namespace Application.UseCases.EmployeeUseCases.GetEmployeeById
{
    public interface IGetEmployeeByIdOutputPort
    {
        Task Handle(EmployeeDTO employee);
    }
}
