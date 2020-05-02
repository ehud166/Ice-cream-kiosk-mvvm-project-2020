using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamKiosk.ViewModel
{
    public class RateIceCreamDoneViewModel : ViewModelBase
    {
        public interface IRateIceCreamDone : IError
        {
            void MoveToBegining();
        }
        public IRateIceCreamDone Wizard;
        public RelayCommand GoToBegining { get; set; }
        public RateIceCreamDoneViewModel()
        {
            GoToBegining = new RelayCommand(
               async () => {
                   if (Wizard != null)
                   {
                       await Task.Delay(2000);
                       Wizard.MoveToBegining();
                   }
                   }
               );
        }

    }
}
