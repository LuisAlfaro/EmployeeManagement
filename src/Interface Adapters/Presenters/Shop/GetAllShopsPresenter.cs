using Application.DTOs;
using Application.UseCases.ShopUseCases.GeAllShops;

namespace Presenters.Employee
{
    public class GetAllShopsPresenter :
        IGeAllShopsOutputPort, IPresenter<IEnumerable<ShopDTO>>
    {
        public IEnumerable<ShopDTO> Content { get; private set; }

        public Task Handle(IEnumerable<ShopDTO> shops)
        {
            Content = shops;
            return Task.CompletedTask;
        }
    }
}
