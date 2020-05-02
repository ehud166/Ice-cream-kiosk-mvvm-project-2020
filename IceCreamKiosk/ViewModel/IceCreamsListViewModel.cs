using BE;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamKiosk.ViewModel
{
    public delegate void MoveToIceCream(IceCream iceCream);

    public class IceCreamsListViewModel : ViewModelBase
    {
        public event MoveToIceCream MoveToIceCream;
        public RelayCommand<IceCream> SelectIceCreamCommand { get; set; }

        public IceCreamsListViewModel() : base()
        {
            SelectIceCreamCommand = new RelayCommand<IceCream>(
                    x =>
                    {
                        MoveToIceCream?.Invoke(x);
                    });

            if (IsInDesignMode)
            {
                IceCreams.Add(new IceCream
                {
                    Name = "sdsd",
                    Description = "fdfdf",
                    Rate = 4,
                    Nutrients = new Nutritions { Energy = 200, Carbohydrate = 120, Cholesterol = 25, Fiber = 55, Protein = 55, Sugars = 62, TotalFat = 82 },
                    Reviews = new List<Review>()
                });
                IceCreams.Add(new IceCream
                {
                    Name = "sdsd",
                    Description = "fdfdf",
                    Rate = 4,
                    Nutrients = new Nutritions { Energy = 200, Carbohydrate = 120, Cholesterol = 25, Fiber = 55, Protein = 55, Sugars = 62, TotalFat = 82 },
                    Reviews = new List<Review>()
                });
                IceCreams.Add(new IceCream
                {
                    Name = "sdsd",
                    Description = "fdfdf",
                    Rate = 4,
                    Nutrients = new Nutritions { Energy = 200, Carbohydrate = 120, Cholesterol = 25, Fiber = 55, Protein = 55, Sugars = 62, TotalFat = 82 },
                    Reviews = new List<Review>()
                });
                IceCreams.Add(new IceCream
                {
                    Name = "sdsd",
                    Description = "fdfdf",
                    Rate = 4,
                    Nutrients = new Nutritions { Energy = 200, Carbohydrate = 120, Cholesterol = 25, Fiber = 55, Protein = 55, Sugars = 62, TotalFat = 82 },
                    Reviews = new List<Review>()
                });
                IceCreams.Add(new IceCream
                {
                    Name = "sdsd",
                    Description = "fdfdf",
                    Rate = 4,
                    Nutrients = new Nutritions { Energy = 200, Carbohydrate = 120, Cholesterol = 25, Fiber = 55, Protein = 55, Sugars = 62, TotalFat = 82 },
                    Reviews = new List<Review>()
                });
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

    }
}
