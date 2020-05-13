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
            foreach (IceCream iceCream in shop.IceCreams)
            {
                iceCream.Nutrients = nutritionService.GetNutritionInformation(iceCream.Name);

            }
            await shopService.AddShop(shop);
        }

        public async Task UpdateShop(Shop shop)
        {
            ShopService shopService = new ShopService();
            foreach (IceCream iceCream in shop.IceCreams)
            {
                iceCream.Nutrients = nutritionService.GetNutritionInformation(iceCream.Name);
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

        public double GetDistanceBetweenPoints(double lat1, double long1, double lat2, double long2)
        {
            double distance = 0;

            double dLat = (lat2 - lat1) / 180 * Math.PI;
            double dLong = (long2 - long1) / 180 * Math.PI;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2)
                        + Math.Cos(lat2) * Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            //Calculate radius of earth
            // For this you can assume any of the two points.
            double radiusE = 6378135; // Equatorial radius, in meters
            double radiusP = 6356750; // Polar Radius

            //Numerator part of function
            double nr = Math.Pow(radiusE * radiusP * Math.Cos(lat1 / 180 * Math.PI), 2);
            //Denominator part of the function
            double dr = Math.Pow(radiusE * Math.Cos(lat1 / 180 * Math.PI), 2)
                            + Math.Pow(radiusP * Math.Sin(lat1 / 180 * Math.PI), 2);
            double radius = Math.Sqrt(nr / dr);

            //Calculate distance in meters.
            distance = radius * c;
            return distance;
        }


    }       
}
