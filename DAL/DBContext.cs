using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBContext: DbContext
    {
        public DBContext() : base()
        {
            this.Configuration.LazyLoadingEnabled = false;

        }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<IceCream> IceCreams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Nutritions> Nutrients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nutritions>()
                .HasOptional<IceCream>(s => s.IceCream)
                .WithRequired(ad => ad.Nutrients)
                .WillCascadeOnDelete(true);
        }
    }
}
