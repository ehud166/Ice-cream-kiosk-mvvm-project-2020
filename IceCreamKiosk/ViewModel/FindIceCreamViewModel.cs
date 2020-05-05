        using BE;
using BL;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamKiosk.ViewModel
{
    public class FindIceCreamViewModel : ViewModelBase
    {      

        public interface IFindIceCream: IError
        {
            void LoadIceCreams(List<IceCream> iceCreams);
        }

        public IFindIceCream Wizard { get; set; }

        private IceCreamBL iceCreamBL = new IceCreamBL();
        public RelayCommand MoveToRate { get; set; }
        public RelayCommand FindCommand { get; set; }
        public FindIceCreamViewModel() : base()
        {
          
            FindCommand = new RelayCommand(
                 async () =>
                 {
                     try
                     {
                         Loading = true;
                         var res = await Task.Run(() =>
                          iceCreamBL.FindIceCreams(new Nutritions
                          {
                              Fiber = MinFiber
                          }, new Nutritions
                          {
                              Carbohydrate = MaxCarbohydrate,
                              Cholesterol = MaxCholesterol,
                              Energy = MaxEnergy,
                              Fiber = MaxFiber,
                              Protein = MaxProtein,
                              Sugars = MaxSugars,
                              TotalFat = MaxTotalFat
                          }, ShopDistance, IceCreamDescription));
                         Wizard.LoadIceCreams(res);
                     }catch(Exception e)
                     {
                         Wizard.FireError(e.Message);
                     }
                     finally
                     {
                         Loading = false;
                     }
                 });
            FindCommand.Execute(null);
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

        private int _shopDistance = 15;
        public int ShopDistance
        {
            get
            {
                return _shopDistance;
            }
            set
            {
                if (_shopDistance == value)
                {
                    return;
                }
                _shopDistance = value;
                RaisePropertyChanged("ShopDistance");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _maxEnergy = 500;
        public double MaxEnergy
        {
            get
            {
                return _maxEnergy;
            }
            set
            {
                if (_maxEnergy == value)
                {
                    return;
                }
                _maxEnergy = value;
                RaisePropertyChanged("MaxEnergy");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _maxCarbohydrate = 100;
        public double MaxCarbohydrate
        {
            get
            {
                return _maxCarbohydrate;
            }
            set
            {
                if (_maxCarbohydrate == value)
                {
                    return;
                }
                _maxCarbohydrate = value;
                RaisePropertyChanged("MaxCarbohydrate");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _maxTotalFat = 70;
        public double MaxTotalFat
        {
            get
            {
                return _maxTotalFat;
            }
            set
            {
                if (_maxTotalFat == value)
                {
                    return;
                }
                _maxTotalFat = value;
                RaisePropertyChanged("MaxTotalFat");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _MaxCholesterol = 45;
        public double MaxCholesterol
        {
            get
            {
                return _MaxCholesterol;
            }
            set
            {
                if (_MaxCholesterol == value)
                {
                    return;
                }
                _MaxCholesterol = value;
                RaisePropertyChanged("MaxCholesterol");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _maxSugars = 56;
        public double MaxSugars
        {
            get
            {
                return _maxSugars;
            }
            set
            {
                if (_maxSugars == value)
                {
                    return;
                }
                _maxSugars = value;
                RaisePropertyChanged("MaxSugars");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _maxProtein = 100;
        public double MaxProtein
        {
            get
            {
                return _maxProtein;
            }
            set
            {
                if (_maxProtein == value)
                {
                    return;
                }
                _maxProtein = value;
                RaisePropertyChanged("MaxProtein");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _maxFiber = 400;
        public double MaxFiber
        {
            get
            {
                return _maxFiber;
            }
            set
            {
                if (_maxFiber == value)
                {
                    return;
                }
                _maxFiber = value;
                RaisePropertyChanged("MaxFiber");
                FindCommand.RaiseCanExecuteChanged();
            }
        }

        private double _minFiber = 0;
        public double MinFiber
        {
            get
            {
                return _minFiber;
            }
            set
            {
                if (_minFiber == value)
                {
                    return;
                }
                _minFiber = value;
                RaisePropertyChanged("MinFiber");
                FindCommand.RaiseCanExecuteChanged();
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
