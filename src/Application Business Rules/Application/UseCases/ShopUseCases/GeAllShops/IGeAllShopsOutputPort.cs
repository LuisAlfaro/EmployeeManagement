using Application.DTOs;

namespace Application.UseCases.ShopUseCases.GeAllShops
{
    public interface IGeAllShopsOutputPort
    {
        Task Handle(IEnumerable<ShopDTO> shops);
    }
}
