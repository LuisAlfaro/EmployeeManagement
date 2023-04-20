using Application.DTOs;
using Application.UseCases.EmployeeTypeUseCases.GeAllEmployeeTypes;

namespace Presenters.Employee
{
    public class GetAllEmployeeTypesPresenter :
        IGetAllEmployeeTypesOutputPort, IPresenter<IEnumerable<EmployeeTypeDTO>>
    {
        public IEnumerable<EmployeeTypeDTO> Content { get; private set; }

        public Task Handle(IEnumerable<EmployeeTypeDTO> employeeTypes)
        {
            Content = employeeTypes;
            return Task.CompletedTask;
        }
    }
}
