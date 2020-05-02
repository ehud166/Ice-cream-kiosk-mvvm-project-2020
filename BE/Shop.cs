using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageUri { get; set; }
        public byte [] Image { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSiteLink { get; set; }
        public string SocialMediaLink { get; set; }
        public virtual List<IceCream> IceCreams { get; set; } //The virtual is for lazy loading
    }
}
