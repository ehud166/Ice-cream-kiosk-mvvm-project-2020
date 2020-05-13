using BE;
using BL;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using IceCreamKiosk.Helpers;

namespace IceCreamKiosk.ViewModel
{
    public class RateIceCreamViewModel : ViewModelBase
    {
        public interface IRateDialogIceCream : IError
        {
            void LoadRateView();
            void GoToFinishRating();
        }
        public IRateDialogIceCream Wizard;

        public RelayCommand RateCommand { get; set; }
        public RelayCommand DownloadCommand { get; set; }
        public RelayCommand GoBackCommand { get; set; }

        private IceCreamBL iceCreamBL = new IceCreamBL();
        private BL.ImagesBL bl = new BL.ImagesBL();
        private string imageName = RandomString() + ext;
        private const string ext = ".jpeg";

        public RateIceCreamViewModel()
        {
            try
            {
                Bitmap myBmp = new Bitmap(Properties.Resources.IceCreamIcon);
                QrImage = ImagesBL.GetQrCode(imageName, myBmp);
            }
            catch (Exception e)
            {
                Wizard.FireError(e.Message);
            }

            GoBackCommand = new RelayCommand(
                   () =>
                   {
                       Wizard.LoadRateView();
                       Reset();
                   });

            RateCommand = new RelayCommand(
                async () =>
                {
                    try
                    {
                        Wizard.CancelError();
                        Loading = true;
                        await Task.Run(() => iceCreamBL.RateIceCream(new Review
                        {
                            IceCreamId = IceCream.Id,
                            Message = RateReview,
                            Rate = RateValue,
                            Image = Image
                        }));
                        Wizard.GoToFinishRating();
                        Reset();
                    }
                    catch (Exception e)
                    {
                        Wizard.FireError(e.Message);
                    }
                    finally
                    {
                        Loading = false;
                    }
                }, () =>
                {
                    return RateReview.Length > 0;
                });

            DownloadCommand = new RelayCommand(async () =>
          {
              try
              {
                  Wizard.CancelError();
                  if (IsDownloadComplete == true)
                  {
                      IsDownloadComplete = false;
                      return;
                  }

                  if (DownloadProgress != 0) return;

                  bool isIceCreamImage = await bl.IsImageContainsIceCream(imageName);
                  if (isIceCreamImage)
                      DownloadProgress = 50;
                  else
                      throw new Exception("Error: The image not contains any Ice Cream");

                  Image = await bl.GetImageFromStore(imageName);

                  if (Image != null) { 
                      DownloadProgress = 100;
                      DialogHost.OpenDialogCommand.Execute(null, null);
                      }
                  else
                      throw new Exception("Error: Can't download the image");
                  IsDownloadComplete = true;
                  IsDownloading = false;
                  DownloadProgress = 0;
              }
              catch (Exception e)
              {
                  Wizard.FireError(e.Message);
              }
          });
        }
        public void Reset()
        {
            try
            {
                Wizard.CancelError();
                Image = null;
                IceCream = null;
                RateValue = 4;
                RateReview = "";
                Loading = false;
                Bitmap myBmp = new Bitmap(Properties.Resources.IceCreamIcon);
                QrImage = ImagesBL.GetQrCode(imageName, myBmp);
            }
            catch (Exception e)
            {
                Wizard.FireError(e.Message);
            }
        }
        private static string RandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 12)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private byte[] _image = null;
        public byte[] Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (_image == value)
                {
                    return;
                }
                _image = value;
                RaisePropertyChanged("Image");
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
                RaisePropertyChanged("IceCream");
            }
        }

        private int _rateValue = 4;
        public int RateValue
        {
            get
            {
                return _rateValue;
            }
            set
            {
                if (_rateValue == value)
                {
                    return;
                }
                _rateValue = value;
                RaisePropertyChanged("RateValue");
            }
        }

        private string _rateReview = "";
        public string RateReview
        {
            get
            {
                return _rateReview;
            }
            set
            {
                if (_rateReview == value)
                {
                    return;
                }
                _rateReview = value;
                RaisePropertyChanged("RateReview");
                RateCommand.RaiseCanExecuteChanged();
            }
        }

        private bool _loading = false;
        public bool Loading
        {
            get
            {
                return _loading;
            }
            set
            {
                if (_loading == value)
                {
                    return;
                }
                _loading = value;
                RaisePropertyChanged("Loading");
            }
        }


        private bool _isDownloading;
        public bool IsDownloading
        {
            get { return _isDownloading; }
            set
            {
                if (_isDownloading == value)
                {
                    return;
                }
                _isDownloading = value;
                RaisePropertyChanged("IsDownloading");
            }
        }

        private bool _isDownloadComplete;
        public bool IsDownloadComplete
        {
            get { return _isDownloadComplete; }
            set
            {
                if (_isDownloadComplete == value)
                {
                    return;
                }
                _isDownloadComplete = value;
                RaisePropertyChanged("IsDownloadComplete");
            }
        }

        private double _downloadProgress;
        public double DownloadProgress
        {
            get { return _downloadProgress; }
            set
            {
                if (_downloadProgress == value)
                {
                    return;
                }
                _downloadProgress = value;
                RaisePropertyChanged("DownloadProgress");
            }
        }
    }
}
