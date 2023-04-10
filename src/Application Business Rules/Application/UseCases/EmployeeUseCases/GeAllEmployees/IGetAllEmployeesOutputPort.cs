using Application.DTOs;

namespace Application.UseCases.EmployeeUseCases.GeAllEmployees
{
    public interface IGetAllEmployeesOutputPort
    {
        Task Handle(IEnumerable<EmployeeDTO> employees);
    }
}
