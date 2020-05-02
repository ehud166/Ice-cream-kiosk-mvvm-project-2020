using BE;
using BL;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IceCreamKiosk.ViewModel.FindIceCreamWizardViewModel;

namespace IceCreamKiosk.ViewModel
{
    public class RateIceCreamViewModel : ViewModelBase
    {
        public interface IRateIceCream : IError
        {
            void MoveToRate(IceCream iceCream);
            void MoveToBegining();
        }

        public IRateIceCream Wizard;
        public RelayCommand GoBackCommand { get; set; }
        public RelayCommand FindCommand { get; set; }
        public RelayCommand<IceCream> RateCommand{ get; set; }

        private IceCreamBL iceCreamBL = new IceCreamBL();

        public RateIceCreamViewModel() : base()
        {
           
            GoBackCommand = new RelayCommand(
                   () =>
                    {
                        Wizard.MoveToBegining();
                        Reset();
                    });
            FindCommand = new RelayCommand(
                   async () =>
                     {
                         try
                         {
                             Loading = true;
                             var res = await Task.Run(() =>
                                iceCreamBL.FindIceCreams(IceCreamDescription));
                             IceCreams = new ObservableCollection<IceCream>(res);
                         }
                         catch (Exception e)
                         {
                             Wizard.FireError(e.Message);
                         }
                         finally
                         {
                             Loading = false;
                         }
                     });

            RateCommand = new RelayCommand<IceCream>(
                    x =>
                   {
                       Wizard.MoveToRate(x);
                   });
        }

        public void Reset()
        {
            IceCreamDescription = "";
            IceCreams = new ObservableCollection<IceCream>();
            SelectedIceCream = null;
            Loading = false;
        }

        private string _iceCreamDescription = "";
        public string IceCreamDescription
        {
            get
            {
                return _iceCreamDescription;
            }
            set
            {
                if (_iceCreamDescription == value)
                {
                    return;
                }
                _iceCreamDescription = value;
                RaisePropertyChanged("IceCreamDescription");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<IceCream> _iceCreams = new ObservableCollection<IceCream>();
        public ObservableCollection<IceCream> IceCreams
        {
            get
            {
                return _iceCreams;
            }
            set
            {
                if (_iceCreams == value)
                {
                    return;
                }
                _iceCreams = value;
                RaisePropertyChanged(() => IceCreams);
            }
        }

        private IceCream _selectedIceCream = null;
        public IceCream SelectedIceCream
        {
            get
            {
                return _selectedIceCream;
            }
            set
            {
                if (_selectedIceCream == value)
                {
                    return;
                }
                _selectedIceCream = value;
                RaisePropertyChanged(() => SelectedIceCream);
            }

        }

        private bool _loading = false;
        public bool Loading
        {
            get
            {
                return _loading;
            }
            set
            {
                if (_loading == value)
                {
                    return;
                }
                _loading = value;
                RaisePropertyChanged("Loading");
            }
        }
    }
}
