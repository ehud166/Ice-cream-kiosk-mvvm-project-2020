using BE;
using BL;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using IceCreamKiosk.Controls;
using System.Threading.Tasks;
using static IceCreamKiosk.commands.NavigationCommand;
using static IceCreamKiosk.ViewModel.AdminViewModel;
using static IceCreamKiosk.ViewModel.FindIceCreamViewModel;

namespace IceCreamKiosk.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase, LogInViewModel.ILogin,IAdmin
    {
        public IError Wizard { get; set; }

        public RelayCommand LoadAdminCommand { get; set; }


        private Navigation windowState = Navigation.Find;



        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

            LoadAdminCommand = new RelayCommand(
                () =>
                {
                    if (windowState != Navigation.Admin)
                    {
                        ShowDialog(new LogInControl());
                    }
                    else if (windowState == Navigation.Admin)
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
            (App.Current as App).NavigationCommand.Execute("Admin");
            HideDialog();
            
            AdminButtonIcon = "Logout";
            AdminButtonText = "log out";
            windowState = Navigation.Admin;
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