using BE;
using IceCreamKiosk.commands;
using IceCreamKiosk.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IceCreamKiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationCommand navigationCommand = App.Current.Resources["NavigationCommand"] as NavigationCommand;
            navigationCommand.MainWindow = this;
            navigationCommand.Execute("Find");
        }

        public void ShowControl(UserControl uc)
        {
            ControlPlaceHolder.Children.Clear();
            ControlPlaceHolder.Children.Add(uc);
        }

    }
}
