using Application.DTOs;
using Application.UseCases.EmployeeUseCases.DeleteEmployee;

namespace Presenters.Employee
{
    public class DeleteEmployeePresenter :
        IDeleteEmployeeOutputPort, IPresenter<EmployeeDTO>
    {
        public EmployeeDTO Content { get; private set; }

        public Task Handle()
        {
            return Task.CompletedTask;
        }
    }
}
