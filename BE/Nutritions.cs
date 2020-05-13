using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nutritions
    {
        public double Energy { get; set; }
        public double Carbohydrate { get; set; }
        public double TotalFat { get; set; }
        public double Cholesterol { get; set; }
        public double Sugars { get; set; }
        public double Protein { get; set; }
        public double Fiber { get; set; }

        [Key]
        [ForeignKey("IceCream")]
        public int IceCreamID { get; set; }
        public virtual IceCream IceCream { get; set; }

    }
}
