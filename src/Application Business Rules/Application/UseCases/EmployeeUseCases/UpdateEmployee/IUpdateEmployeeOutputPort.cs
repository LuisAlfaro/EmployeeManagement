using Application.DTOs;

namespace Application.UseCases.EmployeeUseCases.UpdateEmployee
{
    public interface IUpdateEmployeeOutputPort
    {
        Task Handle(EmployeeDTO employee);
    }
}
