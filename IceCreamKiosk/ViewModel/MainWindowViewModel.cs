using BE;
using BL;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using IceCreamKiosk.Controls;
using System.Threading.Tasks;
using IceCreamKiosk.Helpers;
using static IceCreamKiosk.commands.NavigationCommand;
using static IceCreamKiosk.ViewModel.AdminShopListViewModel;
using static IceCreamKiosk.ViewModel.FindBarViewModel;

namespace IceCreamKiosk.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvm</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainWindowViewModel : ViewModelBase, LogInViewModel.ILogin,IAdmin
    {
        public interface IMain : IError
        {
            void MoveToBegining();
        }
        public IMain Wizard { get; set; }

        public RelayCommand LoadAdminCommand { get; set; }
        public RelayCommand GoToBegining { get; set; }

        private Navigation windowState = Navigation.Find;



        /// <summary>
        /// Initializes a new instance of the MainWindowViewModel class.
        /// </summary>
        public MainWindowViewModel()
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
            LoadAdminCommand = new RelayCommand(
                () =>
                {
                    if (windowState != Navigation.AdminShopList)
                    {
                        ShowDialog(new LogInControl());
                    }
                    else if (windowState == Navigation.AdminShopList)
                    {
                        (App.Current as App).NavigationCommand.Execute("Find");
                        AdminButtonIcon = "AccountCircle";
                        AdminButtonText = "log in";
                        windowState = Navigation.Find;
                    }
                });
        }

        bool LogInViewModel.ILogin.Login(string name, string password)
        {
            UsersBL usersLogic = new UsersBL();
            User = usersLogic.GetUserAsync(name, password);
            return User != null;
        }
        
        public void Loged()
        {
            (App.Current as App).NavigationCommand.Execute("AdminShopList");
            HideDialog();
            
            AdminButtonIcon = "Logout";
            AdminButtonText = "log out";
            windowState = Navigation.AdminShopList;
        }

        public void ShowDialog(object dialog)
        {
            DialogContent = dialog;
            IsDialogOpen = true;
        }

        public void HideDialog()
        {
            DialogContent = null;
            IsDialogOpen = false;
        }

        private string _adminButtonIcon = "AccountCircle";
        public string AdminButtonIcon
        {
            get
            {
                return _adminButtonIcon;
            }
            set
            {
                if (_adminButtonIcon == value)
                    return;

                _adminButtonIcon = value;

                RaisePropertyChanged("AdminButtonIcon");
            }
        }
        private string _adminButtonText = "log in";
        public string AdminButtonText
        {
            get
            {
                return _adminButtonText;
            }
            set
            {
                if (_adminButtonText== value)
                    return;

                _adminButtonText = value;

                RaisePropertyChanged("AdminButtonText");
            }
        }

        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                if (_user == value)
                    return;

                _user = value;

                RaisePropertyChanged("User");
            }
        }


        private object _dialogContent = null;
        public object DialogContent
        {
            get { return _dialogContent; }
            set
            {
                if (_dialogContent == value) return;
                _dialogContent = value;
                RaisePropertyChanged("DialogContent");
            }
        }

        private bool _isDialogOpen = false;
        public bool IsDialogOpen
        {
            get { return _isDialogOpen; }
            set
            {
                if (_isDialogOpen == value) return;
                _isDialogOpen = value;
                RaisePropertyChanged("IsDialogOpen");
            }
        }
    }
}