/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:IceCreamKiosk"
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
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
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

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LogInViewModel>();
            SimpleIoc.Default.Register<AdminViewModel>();
            SimpleIoc.Default.Register<ShopViewModel>();
            SimpleIoc.Default.Register<FindIceCreamViewModel>();
            SimpleIoc.Default.Register<FindIceCreamWizardViewModel>();
            SimpleIoc.Default.Register<IceCreamsListViewModel>();
            SimpleIoc.Default.Register<RateIceCreamViewModel>();
            SimpleIoc.Default.Register<RateIceCreamDialogViewModel>();
            SimpleIoc.Default.Register<IceCreamDetailsViewModel>();
            SimpleIoc.Default.Register<RateIceCreamDoneViewModel>();

            Admin.Main = Main;
            IceCreamsList.MoveToIceCream += FindIceCreamWizard.MoveToIceCream;
            RateIceCreamDialog.Wizard = FindIceCreamWizard;
            RateIceCreamDone.Wizard = FindIceCreamWizard;
            //FindIceCreamWizard.RateIceCreamView = RateIceCream;
            FindIceCreamWizard.RateIceCreamDialogView = RateIceCreamDialog;
            FindIceCreamWizard.RateIceCreamDoneView = RateIceCreamDone;
            IceCreamDetails.Wizard = FindIceCreamWizard;
            Main.Wizard = FindIceCreamWizard;
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
    
        public LogInViewModel Login
        {
            get
            {
                var login = ServiceLocator.Current.GetInstance<LogInViewModel>();
                login.Login = Main;
                return login;
            }
        }

        public AdminViewModel Admin
        {
            get
            {
                var admin = ServiceLocator.Current.GetInstance<AdminViewModel>();
                return admin;
            }
        }

        public ShopViewModel Shop
        {
            get
            {
                var shop = ServiceLocator.Current.GetInstance<ShopViewModel>();
                shop.ShopI = Admin;
                return shop;
            }
        }

        public FindIceCreamViewModel FindIceCream
        {
            get
            {
                var findIceCream = ServiceLocator.Current.GetInstance<FindIceCreamViewModel>();
                findIceCream.Wizard = FindIceCreamWizard;
                return findIceCream;
            }
        }

        public FindIceCreamWizardViewModel FindIceCreamWizard
        {
            get
            {
                FindIceCreamWizardViewModel findIceCreamWizardViewModel = ServiceLocator.Current.GetInstance<FindIceCreamWizardViewModel>();
                findIceCreamWizardViewModel.IceCreamsListView = IceCreamsList;
                findIceCreamWizardViewModel.RateIceCreamDialogView = RateIceCreamDialog;
                findIceCreamWizardViewModel.IceCreamDetailsView = IceCreamDetails;
                return findIceCreamWizardViewModel;
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

        public IceCreamDetailsViewModel IceCreamDetails
        {
            get
            {
                var iceCreamDetails = ServiceLocator.Current.GetInstance<IceCreamDetailsViewModel>();
                return iceCreamDetails;
            }
        }
        

        //public RateIceCreamViewModel RateIceCream
        //{
        //    get
        //    {
        //        var rateIceCream = ServiceLocator.Current.GetInstance<RateIceCreamViewModel>();
        //        rateIceCream.Wizard = FindIceCreamWizard;
        //        return rateIceCream;
        //    }
        //}

        public RateIceCreamDialogViewModel RateIceCreamDialog
        {
            get
            {
                var rateIceCreamDialog = ServiceLocator.Current.GetInstance<RateIceCreamDialogViewModel>();
                return rateIceCreamDialog;
            }
        }

        public RateIceCreamDoneViewModel RateIceCreamDone
        {
            get
            {
               return ServiceLocator.Current.GetInstance<RateIceCreamDoneViewModel>();
            }
        }
    }
}