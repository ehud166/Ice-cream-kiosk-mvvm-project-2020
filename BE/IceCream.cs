using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class IceCream
    {
        public int Id { get; set; }
        public double Rate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public byte[] Image { get; set; }
        public int NdbId { get; set; }
        public virtual Nutritions Nutrients { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; } //The virtual is for lazy loading
    }
}
