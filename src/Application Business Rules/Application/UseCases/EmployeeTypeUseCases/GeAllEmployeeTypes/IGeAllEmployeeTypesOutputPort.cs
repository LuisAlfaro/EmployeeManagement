using Application.DTOs;

namespace Application.UseCases.EmployeeTypeUseCases.GeAllEmployeeTypes
{
    public interface IGetAllEmployeeTypesOutputPort
    {
        Task Handle(IEnumerable<EmployeeTypeDTO> employeeTypes);
    }
}
