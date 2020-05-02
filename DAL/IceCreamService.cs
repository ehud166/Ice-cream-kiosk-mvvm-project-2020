using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IceCreamService
    {
        public async Task<List<IceCream>> FindIceCreams(Nutritions minNutritions, Nutritions maxNutritions, double distance, string description)
        {
            ShopService shopService = new ShopService();
            var shopsInDistance = await shopService.GetShopsIdInDistance(distance);
            using (var db = new DBContext())
            {
                
                var icecreams = await (from icecream in db.IceCreams.Include(i => i.Nutrients).Include(i => i.Shop).Include(i => i.Reviews)
                                       where shopsInDistance.Contains(icecream.ShopId) &&
                                             icecream.Description.Contains(description) &&
                                             icecream.Nutrients.Energy >= minNutritions.Energy &&
                                             icecream.Nutrients.Energy <= maxNutritions.Energy &&

                                             icecream.Nutrients.Carbohydrate >= minNutritions.Carbohydrate &&
                                             icecream.Nutrients.Carbohydrate <= maxNutritions.Carbohydrate &&

                                             icecream.Nutrients.TotalFat >= minNutritions.TotalFat &&
                                             icecream.Nutrients.TotalFat <= maxNutritions.TotalFat &&

                                             icecream.Nutrients.Cholesterol >= minNutritions.Cholesterol &&
                                             icecream.Nutrients.Cholesterol <= maxNutritions.Cholesterol &&

                                             icecream.Nutrients.Sugars >= minNutritions.Sugars &&
                                             icecream.Nutrients.Sugars <= maxNutritions.Sugars &&

                                             icecream.Nutrients.Protein >= minNutritions.Protein &&
                                             icecream.Nutrients.Protein <= maxNutritions.Protein &&

                                             icecream.Nutrients.Fiber >= minNutritions.Fiber &&
                                             icecream.Nutrients.Fiber <= maxNutritions.Fiber
                                       select icecream).ToListAsync();
                return icecreams;
            }
        }

        public async Task<List<IceCream>> FindIceCreams(string description)
        {
            using (var db = new DBContext())
            {

                var icecreams = await (from icecream in db.IceCreams.Include(i => i.Nutrients).Include(i => i.Shop).Include(i => i.Reviews)
                                       where  icecream.Description.Contains(description) 
                                       select icecream).ToListAsync();
                return icecreams;
            }
        }

        public async Task RateIceCream( Review review)
        {
            using (var db = new DBContext())
            {
                var shops = db.Set<Review>();
                shops.Add(review);
                await db.SaveChangesAsync();

                //var iceCreamDB = await db.IceCreams.Include(i => i.Reviews).FirstOrDefaultAsync(i => i.Id == review.IceCreamId);
                var iceCream = await db.IceCreams.FirstOrDefaultAsync(i => i.Id == review.IceCreamId);
                var oldScore = iceCream.Rate;
                double newScore = (oldScore + review.Rate) / 2.0 ;
                iceCream.Rate = newScore;
                await db.SaveChangesAsync();

            }
        }
    }
}
