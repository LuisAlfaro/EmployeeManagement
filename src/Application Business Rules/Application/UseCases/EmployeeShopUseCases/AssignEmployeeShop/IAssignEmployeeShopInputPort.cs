using Application.DTOs;

namespace Application.UseCases.EmployeeShopUseCases.AssignEmployeeShop
{
    public interface IAssignEmployeeShopInputPort
    {
        Task Handle(AssignEmployeeShopDTO assignEmployeeShopDTO);
    }
}
