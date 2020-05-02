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
        public double Energy { get; set; } //kcal
        public double Carbohydrate { get; set; } //g
        public double TotalFat { get; set; }//Total lipid (fat) g
        public double Cholesterol { get; set; }//mg
        public double Sugars { get; set; }//g
        public double Protein { get; set; }//g
        public double Fiber { get; set; }//g

        [Key]
        [ForeignKey("IceCream")]
        public int IceCreamID { get; set; }
        public virtual IceCream IceCream { get; set; }

    }
}
