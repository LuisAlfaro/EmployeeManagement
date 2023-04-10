using Application.DTOs;

namespace Application.UseCases.EmployeeUseCases.UpdateEmployee
{
    public interface IUpdateEmployeeInputPort
    {
        Task Handle(EmployeeDTO employee);
    }
}
