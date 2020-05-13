/*
  In App.xaml:
  <Application.Resources>
      <vm:LocatorViewModel xmlns:vm="clr-namespace:IceCreamKiosk"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;

namespace IceCreamKiosk.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class LocatorViewModel
    {
        /// <summary>
        /// Initializes a new instance of the LocatorViewModel class.
        /// </summary>
        public LocatorViewModel()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //if (ViewModelBase.IsInDesignModeStatic)
            //{
            //    // Create design time view services and models
            //    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            //}
            //else
            //{
            //    // Create run time view services and models
            //    SimpleIoc.Default.Register<IDataService, DataService>();
            //}

            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<LogInViewModel>();
            SimpleIoc.Default.Register<AdminShopListViewModel>();
            SimpleIoc.Default.Register<UpdateShopViewModel>();
            SimpleIoc.Default.Register<FindBarViewModel>();
            SimpleIoc.Default.Register<IceCreamWizardViewModel>();
            SimpleIoc.Default.Register<IceCreamsListViewModel>();
            SimpleIoc.Default.Register<RateIceCreamViewModel>();
            SimpleIoc.Default.Register<IceCreamInformationViewModel>();
            SimpleIoc.Default.Register<ThanksForRateViewModel>();

            AdminShopList.Main = MainWindow;
            IceCreamsList.MoveToIceCream += IceCreamWizard.MoveToIceCream;
            RateIceCream.Wizard = IceCreamWizard;
            ThanksForRate.Wizard = IceCreamWizard;
            FindBar.Wizard = IceCreamWizard;
            IceCreamWizard.RateIceCreamView = RateIceCream;
            IceCreamWizard.FindBarViewModel = FindBar;
            IceCreamWizard.ThanksForRateView = ThanksForRate;
            IceCreamInformation.Wizard = IceCreamWizard;
            MainWindow.Wizard = IceCreamWizard;
        }

        public MainWindowViewModel MainWindow
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }
    
        public LogInViewModel Login
        {
            get
            {
                var login = ServiceLocator.Current.GetInstance<LogInViewModel>();
                login.Login = MainWindow;
                return login;
            }
        }

        public AdminShopListViewModel AdminShopList
        {
            get
            {
                var admin = ServiceLocator.Current.GetInstance<AdminShopListViewModel>();
                return admin;
            }
        }

        public UpdateShopViewModel UpdateShop
        {
            get
            {
                var shop = ServiceLocator.Current.GetInstance<UpdateShopViewModel>();
                shop.ShopI = AdminShopList;
                return shop;
            }
        }

        public FindBarViewModel FindBar
        {
            get
            {
                var findIceCream = ServiceLocator.Current.GetInstance<FindBarViewModel>();
                return findIceCream;
            }
        }

        public IceCreamWizardViewModel IceCreamWizard
        {
            get
            {
                IceCreamWizardViewModel iceCreamWizardViewModel = ServiceLocator.Current.GetInstance<IceCreamWizardViewModel>();
                iceCreamWizardViewModel.IceCreamsListView = IceCreamsList;
                iceCreamWizardViewModel.RateIceCreamView = RateIceCream;
                iceCreamWizardViewModel.FindBarViewModel = FindBar;
                iceCreamWizardViewModel.IceCreamInformationView = IceCreamInformation;
                return iceCreamWizardViewModel;
            }
        }

        public IceCreamsListViewModel IceCreamsList
        {
            get
            {
                var iceCreamsList = ServiceLocator.Current.GetInstance<IceCreamsListViewModel>();
                return iceCreamsList;
            }
        }

        public IceCreamInformationViewModel IceCreamInformation
        {
            get
            {
                var iceCreamDetails = ServiceLocator.Current.GetInstance<IceCreamInformationViewModel>();
                return iceCreamDetails;
            }
        }

        public RateIceCreamViewModel RateIceCream
        {
            get
            {
                var rateIceCreamDialog = ServiceLocator.Current.GetInstance<RateIceCreamViewModel>();
                return rateIceCreamDialog;
            }
        }

        public ThanksForRateViewModel ThanksForRate
        {
            get
            {
               return ServiceLocator.Current.GetInstance<ThanksForRateViewModel>();
            }
        }
    }
}