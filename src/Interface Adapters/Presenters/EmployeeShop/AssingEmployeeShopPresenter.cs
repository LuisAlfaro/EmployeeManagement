using Application.DTOs;
using Application.UseCases.EmployeeShopUseCases.AssignEmployeeShop;

namespace Presenters.EmployeeShop
{
    public class AssingEmployeeShopPresenter:
        IAssignEmployeeShopOutputPort, IPresenter<EmployeeShopDTO>
    {
        public EmployeeShopDTO Content { get; private set; }

        public Task Handle(EmployeeShopDTO employeeShopDTO)
        {
            Content = employeeShopDTO;
            return Task.CompletedTask;
        }
    }
}
