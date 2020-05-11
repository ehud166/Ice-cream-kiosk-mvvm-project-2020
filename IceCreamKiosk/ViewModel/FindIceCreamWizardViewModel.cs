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
using static IceCreamKiosk.ViewModel.FindIceCreamViewModel;
using static IceCreamKiosk.ViewModel.IceCreamDetailsViewModel;
using static IceCreamKiosk.ViewModel.IceCreamsListViewModel;
using static IceCreamKiosk.ViewModel.MainViewModel;
using static IceCreamKiosk.ViewModel.RateIceCreamDialogViewModel;
using static IceCreamKiosk.ViewModel.RateIceCreamDoneViewModel;
using static IceCreamKiosk.ViewModel.RateIceCreamViewModel;

namespace IceCreamKiosk.ViewModel
{
    public class FindIceCreamWizardViewModel : ViewModelBase, IFindIceCream, IIceCreamDetails, /*IRateIceCream,*/ IRateDialogIceCream, IRateIceCreamDone, IMain
    {
        public enum WizardPages
        {
            FoundIceCreams, IceCreamDetails, /*RateIceCream,*/ RateIceCreamDialog, RateIceCreamFinished
        }
        public RelayCommand<object> MoveToSlide { get; set; }
        public IceCreamsListViewModel IceCreamsListView { get; set; }
        public IceCreamDetailsViewModel IceCreamDetailsView { get; set; }
        public FindIceCreamViewModel FindIceCreamViewModel { get; set; }

        public RateIceCreamDialogViewModel RateIceCreamDialogView { get; set; }
        public RateIceCreamViewModel RateIceCreamView { get; set; }
        public RateIceCreamDoneViewModel RateIceCreamDoneView { get; set; }

        public FindIceCreamWizardViewModel()
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
            RateIceCreamDialogView.IceCream = iceCream;
        }

        public void MoveToIceCream(IceCream iceCream)
        {
            SlideIndex = (int)WizardPages.IceCreamDetails;
            IceCreamDetailsView.IceCream = iceCream;
            IceCreamDetailsView.LoadMap.Execute(null);

        }

        public void MoveToBegining()
        {
            SlideIndex = (int)WizardPages.FoundIceCreams;
            FindIceCreamViewModel.ResetBindings();
        }

        public void GoToFinishRating()
        {
            SlideIndex = (int)WizardPages.RateIceCreamFinished;
            RateIceCreamDialogView.Reset();
            //RateIceCreamView.Reset();
            RateIceCreamDoneView.GoToBegining.Execute(null);
        }

        public void FireError(string error)
        {
            HasError = true;
            ErrorMassage = error;
        }

        public void CancleError()
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
