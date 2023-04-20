using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.Repositories
{
    public class ShopRepository : IShopRepository
    {
        readonly DataContext Context;

        public ShopRepository(DataContext context) => Context = context;

        public Shop GetShop(int idShop)
        {
            return Context.Shop
                .First(s => s.Id == idShop);
        }

        public IEnumerable<Shop> GetShops()
        {
            return  Context.Shop.ToList();            
        }
        public void CreateShop(Shop shop)
        {
            Context.Shop.Add(shop);            
        }

        public void UpdateShop(Shop shop)
        {
            var oldShop = Context.Shop.Find(shop.Id);
            if (oldShop != null)
            {
                Context.Shop.Update(shop);
            }
        }

        public void DeleteShop(int idShop)
        {
            var shop = Context.Shop.Find(idShop);
            if (shop != null)
            {
                Context.Shop.Remove(shop);
            }
        }
        
    }
}
