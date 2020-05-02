using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ShopsBL
    {
        private INutritionService nutritionService = new UsdaNutritionService();
        public async Task AddShop(Shop shop)
        {
            ShopService shopService = new ShopService();
            foreach(IceCream iceCream in shop.IceCreams)
            {
                iceCream.Nutrients =  await nutritionService.GetNutritionInformationAsync(iceCream.NdbId);
            }
            await shopService.AddShop(shop);
        }

        public async Task UpdateShop(Shop shop)
        {
            ShopService shopService = new ShopService();
            foreach (IceCream iceCream in shop.IceCreams)
            {
                iceCream.Nutrients = await nutritionService.GetNutritionInformationAsync(iceCream.NdbId);
            }
            await shopService.UpdateShop(shop);
        }

        public async Task DeleteShop(Shop shop)
        {
            ShopService shopService = new ShopService();
             await shopService.DeleteShop(shop);
        }

        public async Task<List<Shop>> GetShops()
        {
            ShopService shopService = new ShopService();
            return await shopService.GetShops();
        }
    }
}
