using Application.DTOs;
using Domain.Interfaces.Repositories;

namespace Application.UseCases.ShopUseCases.GeAllShops
{
    public class GeAllShopsInteractor : IGeAllShopsInputPort
    {
        readonly IShopRepository ShopRepository;
        readonly IGeAllShopsOutputPort OutputPort;

        public GeAllShopsInteractor(IShopRepository shopRepository,
            IGeAllShopsOutputPort outputPort) =>
            (ShopRepository, OutputPort) = (shopRepository, outputPort);

        public Task Handle()
        {
            var shops = ShopRepository.GetShops().Select(shop =>
            new ShopDTO
            {
                Id = shop.Id,
                Name = shop.Name,
                Telephone = shop.Telephone,
                Address = shop.Address
            }
            );
            OutputPort.Handle(shops);
            return Task.CompletedTask;
        }
    }
}
