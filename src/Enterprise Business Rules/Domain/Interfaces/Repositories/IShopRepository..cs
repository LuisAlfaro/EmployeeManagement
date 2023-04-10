using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IShopRepository
    {
        Shop GetShop(int idShop);
        IEnumerable<Shop> GetShop();
        void CreateShop(Shop shop);
        void UpdateShop(Shop shop);       
       
    }
}
