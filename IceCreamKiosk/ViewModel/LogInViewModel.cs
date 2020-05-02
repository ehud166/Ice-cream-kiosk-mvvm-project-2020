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
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace IceCreamKiosk.ViewModel
{
    public class LogInViewModel : ViewModelBase
    {
        public interface ILogin
        {
            bool Login(string name, string password);
            void Loged();
        }
        public ILogin Login { get; set; }
        public RelayCommand LogInCommand { get; set; }
        private string _name ="";
        private string _password ="";
        private bool _running = false;
        private string _errorMassage = "";
        private Visibility _errorMassageVisability = Visibility.Hidden;

        BackgroundWorker bg = new BackgroundWorker();

        public LogInViewModel()
        {
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            LogInCommand = new RelayCommand(
                 () => {
                     Running = true;
                     ErrorMassageVisability = Visibility.Hidden;
                     ErrorMassage = "";
                     bg.RunWorkerAsync();
                 },
                 () => { return !Running && Name.Length > 0 && Password.Length > 0; },
                 true
                 );

        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
               Console.WriteLine("error");
               ErrorMassageVisability = Visibility.Visible;
               ErrorMassage = "Error";
            }
            else
            {
                Login.Loged();
                reset();
            }
            Running = false;
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!Login.Login(Name, Password))
                    e.Cancel = true;
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
            //throw new System.Exception("bla");
        }

        private void reset()
        {
            Name = "";
            Password = "";
            Running = false;
            ErrorMassage = "";
            ErrorMassageVisability = Visibility.Hidden;
         
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value)
                {
                    return;
                }
                _name = value;
                RaisePropertyChanged("Name");
                LogInCommand.RaiseCanExecuteChanged();
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password == value)
                {
                    return;
                }
                _password = value;
                RaisePropertyChanged("Password");
                LogInCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Running
        {
            get
            {
                return _running;
            }
            set
            {
                if (_running == value)
                {
                    return;
                }
                _running = value;
                RaisePropertyChanged("Running");
                LogInCommand.RaiseCanExecuteChanged();
            }
        }

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
                LogInCommand.RaiseCanExecuteChanged();
            }
        }

        public Visibility ErrorMassageVisability
        {
            get
            {
                return _errorMassageVisability;
            }
            set
            {
                if (_errorMassageVisability == value)
                {
                    return;
                }
                _errorMassageVisability = value;
                RaisePropertyChanged("ErrorMassageVisability");
                LogInCommand.RaiseCanExecuteChanged();
            }
        }
    }
}