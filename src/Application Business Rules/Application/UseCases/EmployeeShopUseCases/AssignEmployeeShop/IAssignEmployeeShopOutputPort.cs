using Application.DTOs;

namespace Application.UseCases.EmployeeShopUseCases.AssignEmployeeShop
{
    public interface IAssignEmployeeShopOutputPort
    {
        Task Handle(EmployeeShopDTO employeeShopDTO);
    }
}
