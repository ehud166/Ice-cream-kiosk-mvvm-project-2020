using BE;
using GalaSoft.MvvmLight.Messaging;
using IceCreamKiosk.ViewModel;
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

namespace IceCreamKiosk.Controls
{
    /// <summary>
    /// Interaction logic for IceCreamDetailsControl.xaml
    /// </summary>
    public partial class IceCreamDetailsControl : UserControl
    {
        IceCreamDetailsViewModel route;
        public IceCreamDetailsControl()
        {
            InitializeComponent();
            Messenger.Default.Register<IceCreamDetailsViewModel>(this, action => SetView(action));
        }

        //This is break the MVVM a little :-(
        private void SetView(IceCreamDetailsViewModel model)
        {
            if (model.Locations.Count > 0)
            {
                List<Microsoft.Maps.MapControl.WPF.Location> locations = new List<Microsoft.Maps.MapControl.WPF.Location>();
                locations.Add(model.StartLocation);
                locations.Add(model.EndLocation);
                route = model;

                Map.SetView(locations, new Thickness(50), 0);
            };
        }

        private void wazeButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.waze.com/he/livemap/directions?to=ll." + route.EndLocation.Latitude +","+ route.EndLocation.Longitude +"&from=ll." + route.StartLocation.Latitude +"," + route.StartLocation.Longitude + "&navigate=yes");


        }

        private void WebSiteLink_Click(object sender, RoutedEventArgs e)
        {
            string ct = ((sender as StackPanel).Children[1] as TextBlock).Text;
            System.Diagnostics.Process.Start(ct);
        }

        private void socialwebLink_Click(object sender, RoutedEventArgs e)
        {

            string ct = ((sender as StackPanel).Children[1] as TextBlock).Text;
            System.Diagnostics.Process.Start(ct);
        }
    }
}
