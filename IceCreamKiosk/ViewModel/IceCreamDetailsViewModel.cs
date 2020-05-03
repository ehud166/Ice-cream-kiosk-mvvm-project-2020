using BE;
using BingMapsRESTToolkit;
using BingMapsRESTToolkit.Extensions;
using BL;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Maps.MapControl.WPF.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace IceCreamKiosk.ViewModel
{
    public class IceCreamDetailsViewModel : ViewModelBase
    {
        public interface IIceCreamDetails: IError
        {
            void MoveToRate(IceCream iceCream);
            //void MoveToBegining();
        }

        MapsBL mapsBL = new MapsBL();

        public RelayCommand wazeQR { get; set; }
        public RelayCommand LoadMap { get; set; }
        public RelayCommand FindWalkRoute { get; set; }
        public RelayCommand FindCarRoute { get; set; }
        public RelayCommand<IceCream> RateCommand{ get; set; }
        public IIceCreamDetails Wizard { get; set; }

        public IceCreamDetailsViewModel():base()
        {
          

            RateCommand = new RelayCommand<IceCream>(
                  x =>
                  {
                      Wizard.MoveToRate(x);
                  });

         
            Locations = new ObservableCollection<BE.Location>();

            FindWalkRoute = new RelayCommand(
                async () =>
                {
                    try
                    {
                        Wizard.CancleError();
                        await loadMap(TravelModeType.Walking);
                    }
                    catch (Exception e)
                    {
                        Wizard.FireError(e.Message);
                    }
                });

            FindCarRoute = new RelayCommand(
                async () =>
                {
                    try
                    {
                        Wizard.CancleError();
                        await loadMap(TravelModeType.Driving);
                    }
                    catch (Exception e)
                    {
                        Wizard.FireError(e.Message);
                    }
                });

            LoadMap = new RelayCommand(
                async () =>
                {
                    try
                    {
                        Wizard.CancleError();
                        await loadMap(TravelModeType.Walking);
                    }
                    catch (Exception e)
                    {
                        Wizard.FireError(e.Message);
                    }
                });

        }

        private async Task loadMap(TravelModeType travelModeType)
        {
            var waypoints = new List<SimpleWaypoint>
                    {
                        new SimpleWaypoint(Properties.Settings.Default.KioskLocationLat, Properties.Settings.Default.KioskLocationLan),
                        new SimpleWaypoint(IceCream.Shop.Address),
                    };

            var routePath = await mapsBL.GetRouteAsLocations(waypoints, Properties.Resources.BingMapsKey, travelModeType);
            var routePolyline = new MapPolyline()
            {
                Opacity = 0.5,
                Locations = routePath,
                Stroke = new SolidColorBrush(Colors.Red),
                StrokeThickness = 4
            };
            Route = new ObservableCollection<MapPolyline>();
            Route.Add(routePolyline);
            StartLocation = new Microsoft.Maps.MapControl.WPF.Location(waypoints[0].Coordinate.Latitude, waypoints[0].Coordinate.Longitude);
            EndLocation = new Microsoft.Maps.MapControl.WPF.Location(waypoints[1].Coordinate.Latitude, waypoints[1].Coordinate.Longitude);

            Locations.Clear();
            Locations.Add(new BE.Location
            {
                BingLocation = StartLocation,
                Address = "",
                Name = "Your Location"
            });
            Locations.Add(new BE.Location
            {
                BingLocation = EndLocation,
                Address = IceCream.Shop.Address,
                Name = IceCream.Shop.Name
            });
            Bitmap myBmp = new Bitmap(Properties.Resources.IceCreamIcon);
            QrImage = ImagesBL.GetWazeQrCode(waypoints, myBmp);
            Messenger.Default.Send<IceCreamDetailsViewModel>(this);
        }
        public ObservableCollection<BE.Location> Locations { get; private set; }

        private Microsoft.Maps.MapControl.WPF.Location _startLocation = null;
        public Microsoft.Maps.MapControl.WPF.Location StartLocation
        {
            get
            {
                return _startLocation;
            }
            set
            {
                if (_startLocation == value)
                {
                    return;
                }
                _startLocation = value;
                RaisePropertyChanged(() => StartLocation);
            }
        }

        private Microsoft.Maps.MapControl.WPF.Location _endLocation = null;
        public Microsoft.Maps.MapControl.WPF.Location EndLocation
        {
            get
            {
                return _endLocation;
            }
            set
            {
                if (_endLocation == value)
                {
                    return;
                }
                _endLocation = value;
                RaisePropertyChanged(() => EndLocation);
            }
        }


        private ObservableCollection<MapPolyline> _route = new ObservableCollection<MapPolyline>();
        public ObservableCollection<MapPolyline> Route
        {
            get
            {
                return _route;
            }
            set
            {
                if (_route == value)
                {
                    return;
                }
                _route = value;
                RaisePropertyChanged(() => Route);
            }
        }

        private IceCream _iceCream = null;
        public IceCream IceCream
        {
            get
            {
                return _iceCream;
            }
            set
            {
                if (_iceCream == value)
                {
                    return;
                }
                _iceCream = value;
                RaisePropertyChanged(() => IceCream);
            }
        }

        private byte[] _qrImage = null;
        public byte[] QrImage
        {
            get
            {
                return _qrImage;
            }
            set
            {
                if (_qrImage == value)
                {
                    return;
                }
                _qrImage = value;
                RaisePropertyChanged("QrImage");
            }
        }

        public CredentialsProvider BingMapsKey { get; } = new ApplicationIdCredentialsProvider(Properties.Resources.BingMapsKey);
    }
}