using IceCreamKiosk.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace IceCreamKiosk.commands
{
    public class NavigationCommand : ICommand
    {
        public enum Navigation
        {
           AdminShopList, Find
        }

        public NavigationCommand()
        {
            UserControls = new Stack<UserControl>();
        }

        public MainWindow MainWindow { get; set; }

        public Stack<UserControl> UserControls { get; set; }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is string)
            {
                Navigation navigation = (Navigation)Enum.Parse(typeof(Navigation), parameter as string);

                UserControl uc = GetControl(navigation);

                if (uc != null)
                {
                    MainWindow.ShowControl(uc);
                }

            }
        }

        public UserControl GetControl(Navigation navigation)
        {
            UserControl res = null;

            switch (navigation)
            {
                case Navigation.AdminShopList:
                    res = new AdminShopListControl();
                    break;
                case Navigation.Find:
                    res = new IceCreamWizardControl();
                    break;
            }

            return res;
        }
    }
}
