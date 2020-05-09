using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface INutritionService
    {
        Nutritions GetNutritionInformation(string productName);
    }
}
