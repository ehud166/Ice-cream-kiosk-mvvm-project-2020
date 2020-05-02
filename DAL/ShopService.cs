using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShopService
    {
        public async Task AddShop(Shop shop)
        {
            using (var db = new DBContext())
            {
                    var shops = db.Set<Shop>();
                    shops.Add(shop);
                   await db.SaveChangesAsync();
            }
        }

        public async Task UpdateShop(Shop shop)
        {
            using (var db = new DBContext())
            {
                var result = db.Shops.Include(s => s.IceCreams).SingleOrDefault(b => b.Id == shop.Id);
                if (result != null)
                {
                    foreach (var iceCream in result.IceCreams.ToList())
                    {
                        if (!shop.IceCreams.Any(c => c.Id == iceCream.Id))
                            db.IceCreams.Remove(iceCream);
                    }

                    // Update and Insert children
                    foreach (var iceCream in shop.IceCreams)
                    {
                        var existingIceCream = result.IceCreams
                            .Where(c => c.Id == iceCream.Id)
                            .SingleOrDefault();

                        if (existingIceCream != null)
                            // Update child
                            db.Entry(existingIceCream).CurrentValues.SetValues(iceCream);
                        else
                        {
                            // Insert child                           
                            result.IceCreams.Add(iceCream);
                        }
                    }
                    db.Entry(result).CurrentValues.SetValues(shop);
                    await db.SaveChangesAsync();

                }
            }
        }

        public async Task DeleteShop(Shop shop)
        {
            using (var db = new DBContext())
            {
                var result = await db.Shops.Include(i => i.IceCreams).SingleOrDefaultAsync(b => b.Id == shop.Id);
                if (result != null)
                {
                    db.Shops.Remove(result);
                    await db.SaveChangesAsync();
                }
            }
        }

        public Shop GetShop(int id)
        {
            using (var db = new DBContext())
            {
                var shops = (from shop in db.Shops
                             where shop.Id == id 
                             select shop).ToList();

                if (shops.Count == 1)
                {
                    return shops.First();
                }
                else if (shops.Count == 0)
                {
                    return null;
                }
                else
                {
                    throw new Exception("Critical error, we can't get the shops details, check your DB");
                }
            }
        }

        public async Task<List<Shop>> GetShops()
        {
            using (var db = new DBContext())
            {
                var shops = await (from shop in db.Shops.Include(s => s.IceCreams)
                             select shop).ToListAsync();                
                    return shops;
            }
        }

        public async Task<List<int>> GetShopsIdInDistance(double distance)
        {
            //implement with location service
            using (var db = new DBContext())
            {
                var shops = await (from shop in db.Shops.Include(s => s.IceCreams)
                                   select shop.Id).ToListAsync();
                return shops;
            }
        }
    }
}
