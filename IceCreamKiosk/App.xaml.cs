using IceCreamKiosk.commands;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IceCreamKiosk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>ha k
    public partial class App : Application
    {
        public NavigationCommand NavigationCommand
        {
            get { return Resources["NavigationCommand"] as NavigationCommand; }
        }
    }
}
