using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Review
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Message { get; set; }
        public string ImageUri { get; set; }
        public byte [] Image { get; set; }
        public int IceCreamId { get; set; }
        public virtual IceCream IceCream { set; get; }
    }
}
