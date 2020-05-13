using BE;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IceCreamKiosk.ViewModel.FindBarViewModel;
using static IceCreamKiosk.ViewModel.IceCreamInformationViewModel;
using static IceCreamKiosk.ViewModel.IceCreamsListViewModel;
using static IceCreamKiosk.ViewModel.MainWindowViewModel;
using static IceCreamKiosk.ViewModel.RateIceCreamViewModel;
using static IceCreamKiosk.ViewModel.ThanksForRateViewModel;

namespace IceCreamKiosk.ViewModel
{
    public class IceCreamWizardViewModel : ViewModelBase, IFindIceCream, IIceCreamDetails, /*IRateIceCream,*/ IRateDialogIceCream, IRateIceCreamDone, IMain
    {
        public enum WizardPages
        {
            FoundIceCreams, IceCreamDetails, /*RateIceCreamControl,*/ RateIceCreamDialog, RateIceCreamFinished
        }
        public RelayCommand<object> MoveToSlide { get; set; }
        public IceCreamsListViewModel IceCreamsListView { get; set; }
        public IceCreamInformationViewModel IceCreamInformationView { get; set; }
        public FindBarViewModel FindBarViewModel { get; set; }

        public RateIceCreamViewModel RateIceCreamView { get; set; }
        public ThanksForRateViewModel ThanksForRateView { get; set; }

        public IceCreamWizardViewModel()
        {
            MoveToSlide = new RelayCommand<object>(
                x =>
                SlideIndex = int.Parse(x as string)
                );
        }

        public void LoadIceCreams(List<IceCream> iceCreams)
        {
            Transitioner.MoveNextCommand.Execute(null, null);
            IceCreamsListView.IceCreams = new ObservableCollection<IceCream>(iceCreams);
        }

        public void LoadRateView()
        {
            SlideIndex = (int)WizardPages.IceCreamDetails;
        }

        public void MoveToRate(IceCream iceCream)
        {
            SlideIndex = (int)WizardPages.RateIceCreamDialog;
            RateIceCreamView.IceCream = iceCream;
        }

        public void MoveToIceCream(IceCream iceCream)
        {
            SlideIndex = (int)WizardPages.IceCreamDetails;
            IceCreamInformationView.IceCream = iceCream;
            IceCreamInformationView.LoadMap.Execute(null);

        }

        public void MoveToBegining()
        {
            SlideIndex = (int)WizardPages.FoundIceCreams;
            FindBarViewModel.ResetBindings();
        }

        public void GoToFinishRating()
        {
            SlideIndex = (int)WizardPages.RateIceCreamFinished;
            RateIceCreamView.Reset();
            ThanksForRateView.GoToBegining.Execute(null);
        }

        public void FireError(string error)
        {
            HasError = true;
            ErrorMassage = error;
        }

        public void CancelError()
        {
            HasError = false;
            ErrorMassage = "";
        }

        private int _slideIndex = 0;
        public int SlideIndex
        {
            get
            {
                return _slideIndex;
            }
            set
            {
                if (_slideIndex == value)
                {
                    return;
                }
                _slideIndex = value;
                RaisePropertyChanged("SlideIndex");
            }
        }

        private string _errorMassage = "";
        public string ErrorMassage
        {
            get
            {
                return _errorMassage;
            }
            set
            {
                if (_errorMassage == value)
                {
                    return;
                }
                _errorMassage = value;
                RaisePropertyChanged("ErrorMassage");
            }
        }

        private bool _hasError = false;
        public bool HasError
        {
            get
            {
                return _hasError;
            }
            set
            {
                if (_hasError == value)
                {
                    return;
                }
                _hasError = value;
                RaisePropertyChanged("HasError");
            }
        }
    }
}
