using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamKiosk.ViewModel
{
    //helper to centrelized the error hendling
    public interface IError
    {
        void FireError(string error);
        void CancleError();
    }
}
