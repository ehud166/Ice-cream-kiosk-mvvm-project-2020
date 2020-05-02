using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class IceCreamBL
    {
        IceCreamService iceCreamService = new IceCreamService();
        public async Task<List<IceCream>> FindIceCreams(Nutritions minNutritions, Nutritions maxNutritions, double distance, string description)
        {
            return await iceCreamService.FindIceCreams(minNutritions, maxNutritions, distance, description);
        }

        public async Task<List<IceCream>> FindIceCreams( string description)
        {
            return await iceCreamService.FindIceCreams(description);
        }

        public async Task RateIceCream(Review review)
        {
            await iceCreamService.RateIceCream(review);
        }

    }
}
