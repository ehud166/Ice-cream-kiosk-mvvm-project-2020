using BE;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace IceCreamKiosk.ViewModel
{
    public class UpdateShopViewModel : ViewModelBase
    {
        public enum Mode { Add, Update }
        public interface IShop
        {
            Task Add(Shop shop);
            Task Update(Shop shop);
            void AddToView(Shop shop);
            void UpdateView();
            void Close();
        }
        public IShop ShopI { get; set; }

        private Shop _currentShop = new Shop()
        {
            Name = "",
            Address = "",
            Image = null,
            PhoneNumber = "",
            SocialMediaLink = "",
            WebSiteLink = "",
            ImageUri = "",
            IceCreams = new List<IceCream>()
        };
        public Shop CurrentShop
        {
            get
            {
                return _currentShop;
            }
            set
            {
                if (_currentShop == value)
                {
                    return;
                }
                _currentShop = value;
                Name = _currentShop.Name;
                Address = _currentShop.Address;
                PhoneNumber = _currentShop.PhoneNumber;
                WebSiteLink = _currentShop.WebSiteLink;
                SocialMediaLink = _currentShop.SocialMediaLink;
                if (_currentShop.IceCreams != null)
                    IceCreams = new ObservableCollection<IceCream>(_currentShop.IceCreams);
                Id = _currentShop.Id;
                Image = _currentShop.Image;

                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand ShopCommand { get; set; }
        public RelayCommand<IceCream> DeleteIceCreamCommand { get; set; }
        public RelayCommand AddIceCreamCommand { get; set; }
        public RelayCommand<string> GetImageFromUri { get; set; }
        public RelayCommand GetImageFromFile { get; set; }
        public RelayCommand<IceCream> GetIceCreamImageFromFile { get; set; }



        public UpdateShopViewModel() : base()
        {
            ShopCommand = new RelayCommand(
               async () =>
                {
                    Running = true;
                    ErrorMassageVisability = Visibility.Hidden;
                    ErrorMassage = "";
                    CurrentShop = new Shop
                    {
                        Id = Id,
                        Name = Name,
                        Address = Address,
                        IceCreams = IceCreams.ToList(),
                        ImageUri = ImageUri,
                        Image = Image,
                        PhoneNumber = PhoneNumber,
                        SocialMediaLink = SocialMediaLink,
                        WebSiteLink = WebSiteLink
                    };
                    try
                    {
                        if (ModelMode == Mode.Add)
                        {
                            await ShopI.Add(CurrentShop);
                        }
                        else
                        {
                            await ShopI.Update(CurrentShop);
                        }
                        ShopI.Close();
                        if (ModelMode == Mode.Add)
                            ShopI.AddToView(CurrentShop);
                        else if(ModelMode == Mode.Update)
                            ShopI.UpdateView();
                        CurrentShop = new Shop
                        {
                            Name = "",
                            Address = "",
                            ImageUri = "",
                            Image = null,
                            PhoneNumber = "",
                            SocialMediaLink = "",
                            WebSiteLink = "",
                            IceCreams = new List<IceCream>()
                        };
                    }
                    catch (Exception ex)
                    {
                        ErrorMassageVisability = Visibility.Visible;
                        ErrorMassage = ex.Message;
                    }
                    finally
                    {
                        Running = false;
                    }
                },
                () =>
                {
                    return !Running && (IsImageDownloaded || Image != null)
                    && Name.Length > 0
                    && PhoneNumber.Length > 0
                    && WebSiteLink.Length > 0
                    && Address.Length > 0;
                },
                true
                );

            AddIceCreamCommand = new RelayCommand(
                () => { IceCreams.Add(new IceCream()); },
                () => { return true; },
                true);

            DeleteIceCreamCommand = new RelayCommand<IceCream>(
                   x =>
                   {
                       IceCreams.Remove(x);
                   },
                   x => { return SelectedIceCream != null; }, true);

            GetImageFromUri = new RelayCommand<string>(
                 async s =>
                 {
                     try
                     {
                         BL.ImagesBL bl = new BL.ImagesBL();
                         Image = await bl.GetImageFromUri(s);
                         if (Image != null)
                             IsImageDownloaded = true;
                     }
                     catch (Exception e)
                     {
                         ErrorMassageVisability = Visibility.Visible;
                         ErrorMassage = e.Message;
                     }
                 },
                   x => { return ImageUri != null && ImageUri.Length > 0; }, true);

            GetImageFromFile = new RelayCommand(
               () =>
               {
                   try
                   {
                       IsImageDownloaded = false;
                       byte[] bytes = getImageFromFile(true);
                       if (bytes != null)
                       {
                           Image = bytes;
                           IsImageDownloaded = true;
                       }
                   }
                   catch (Exception e)
                   {
                       ErrorMassageVisability = Visibility.Visible;
                       ErrorMassage = e.Message;
                   }
               });

            GetIceCreamImageFromFile = new RelayCommand<IceCream>(
                i =>
                {
                    try
                    {
                        byte[] bytes = getImageFromFile(false);
                        if (bytes != null)
                        {
                            IceCreams.Where(ice => ice.Id == i.Id).FirstOrDefault().Image = bytes;
                            RaisePropertyChanged(() => IceCreams);
                        }
                    }
                    catch (Exception e)
                    {
                        ErrorMassageVisability = Visibility.Visible;
                        ErrorMassage = e.Message;
                    }
                });
        }

        private byte[] getImageFromFile(bool saveFileName)
        {
            byte[] bytes = null;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "choose an image file";
            fd.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            if ((bool)fd.ShowDialog())
            {
                var imageIn = System.Drawing.Image.FromFile(fd.FileName);
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    bytes = ms.ToArray();
                    if (saveFileName)
                        ImageUri = fd.FileName;

                }
            }
            return bytes;
        }

        public void ResetBindings()
        {
            ImageUri = "";
            CurrentShop = new Shop()
            {
                Name = "",
                Address = "",
                Image = null,
                PhoneNumber = "",
                SocialMediaLink = "",
                WebSiteLink = "",

                IceCreams = new List<IceCream>()
            };
        }

        private int _id = 0;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id == value)
                {
                    return;
                }
                _id = value;
                RaisePropertyChanged(() => Id);
            }
        }

        private string _name = "";
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
                RaisePropertyChanged(() => Name);
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private string _address = "";
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (_address == value)
                {
                    return;
                }
                _address = value;
                RaisePropertyChanged(() => Address);
                ShopCommand.RaiseCanExecuteChanged();
            }
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
                RaisePropertyChanged(() => Image);
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private bool _isImageDownloaded = false;
        public bool IsImageDownloaded
        {
            get
            {
                return _isImageDownloaded;
            }
            set
            {
                if (_isImageDownloaded == value)
                {
                    return;
                }
                _isImageDownloaded = value;
                RaisePropertyChanged(() => IsImageDownloaded);
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private string _imageUri;
        public string ImageUri
        {
            get
            {
                return _imageUri;
            }
            set
            {
                if (_imageUri == value)
                {
                    return;
                }
                _imageUri = value;
                RaisePropertyChanged(() => ImageUri);
                ShopCommand.RaiseCanExecuteChanged();
                GetImageFromUri.RaiseCanExecuteChanged();
            }
        }

        private string _phoneNumber = "";
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (_phoneNumber == value)
                {
                    return;
                }
                _phoneNumber = value;
                RaisePropertyChanged(() => PhoneNumber);
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private string _webSiteLink = "";
        public string WebSiteLink
        {
            get
            {
                return _webSiteLink;
            }
            set
            {
                if (_webSiteLink == value)
                {
                    return;
                }
                _webSiteLink = value;
                RaisePropertyChanged(() => WebSiteLink);
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private string _socialMediaLink = "";
        public string SocialMediaLink
        {
            get
            {
                return _socialMediaLink;
            }
            set
            {
                if (_socialMediaLink == value)
                {
                    return;
                }
                _socialMediaLink = value;
                RaisePropertyChanged(() => SocialMediaLink);
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private ObservableCollection<IceCream> _iceCreams = new ObservableCollection<IceCream>();
        public ObservableCollection<IceCream> IceCreams
        {
            get
            {
                return _iceCreams;
            }
            set
            {
                if (_iceCreams == value)
                {
                    return;
                }
                _iceCreams = value;
                RaisePropertyChanged(() => IceCreams);
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private IceCream _selectedIceCream = null;
        public IceCream SelectedIceCream
        {
            get
            {
                return _selectedIceCream;
            }
            set
            {
                if (_selectedIceCream == value)
                {
                    return;
                }
                _selectedIceCream = value;
                RaisePropertyChanged(() => SelectedIceCream);
                DeleteIceCreamCommand.RaiseCanExecuteChanged();
            }

        }

        private Mode _modelMode = Mode.Add;
        public Mode ModelMode
        {
            get
            {
                return _modelMode;
            }
            set
            {
                if (_modelMode == value)
                {
                    return;
                }
                _modelMode = value;
                RaisePropertyChanged(() => ShopButtonText);
            }
        }
        public string ShopButtonText
        {
            get
            {
                if (ModelMode == Mode.Add)
                    return "Add";
                else
                    return "Update";
            }
        }

        private bool _running = false;
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
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private string _errorMassage = "";
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
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        private Visibility _errorMassageVisability = Visibility.Hidden;
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
                ShopCommand.RaiseCanExecuteChanged();
            }
        }

        public IEnumerable<Object> NdbIds
        {
            get
            {
                yield return new { NdbId = "19095", Name = "Vanilla" };
                yield return new { NdbId = "19271", Name = "Strawberry" };
                yield return new { NdbId = "19270", Name = "Chocolate" };
                yield return new { NdbId = "1239", Name = "Cookie sandwich" };
            }
        }

        public IEnumerable<double> Rates
        {
            get
            {
                yield return 1;
                yield return 2;
                yield return 3;
                yield return 4;
                yield return 5;

            }
        }
    }
}
