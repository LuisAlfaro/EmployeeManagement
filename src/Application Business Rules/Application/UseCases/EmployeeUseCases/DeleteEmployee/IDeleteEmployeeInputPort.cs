using Application.DTOs;

namespace Application.UseCases.EmployeeUseCases.DeleteEmployee
{
    public interface IDeleteEmployeeInputPort
    {
        Task Handle(int id);
    }
}
