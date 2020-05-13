using BE;
using BL;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using IceCreamKiosk.Controls;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static IceCreamKiosk.ViewModel.UpdateShopViewModel;

namespace IceCreamKiosk.ViewModel
{
    public class AdminShopListViewModel : ViewModelBase, IShop
    {
        public interface IAdmin
        {
            void ShowDialog(object dialog);
            void HideDialog();
        }
        public RelayCommand ViewIceCreamsCommand { get; set; }
        public RelayCommand AddShopCommand { get; set; }
        public RelayCommand<Shop> EditShopCommand { get; set; }
        public RelayCommand<Shop> DeleteShopCommand { get; set; }
        public IAdmin Main;

        ShopsBL shopsBL = new ShopsBL();
        
        public AdminShopListViewModel() : base()
        {
            AddShopCommand = new RelayCommand(
                    () =>
                    {
                        try
                        {
                            var view = new UpdateShopControl();
                            UpdateShopViewModel updateShopVm = ServiceLocator.Current.GetInstance<UpdateShopViewModel>();
                            updateShopVm.ResetBindings();
                            updateShopVm.ModelMode = UpdateShopViewModel.Mode.Add;
                            view.DataContext = updateShopVm;
                            updateShopVm.ResetBindings();
                            //show the dialog
                            Main.ShowDialog(view);
                        }
                        catch (Exception e)
                        {
                            ErrorMassage = e.Message;
                            HasError = true;
                        }
                    }
                , () => { return !HasError; });

            EditShopCommand = new RelayCommand<Shop>(
                   (x) =>
                   {
                       try
                       {
                           var view = new UpdateShopControl();
                           UpdateShopViewModel updateShopVm = ServiceLocator.Current.GetInstance<UpdateShopViewModel>();
                           updateShopVm.ResetBindings();
                           updateShopVm.ModelMode = UpdateShopViewModel.Mode.Update;
                           updateShopVm.CurrentShop = x;
                           view.DataContext = updateShopVm;
                           //show the dialog
                           Main.ShowDialog(view);
                       }
                       catch (Exception e)
                       {
                           ErrorMassage = e.Message;
                           HasError = true;
                       }

                   }
               , x => { return !HasError; });
            DeleteShopCommand = new RelayCommand<Shop>(
                  async x =>
                  {
                      try
                      {
                          Shops.Remove(x);
                          ShopsBL shopsBL = new ShopsBL();
                          await Task.Run(() => shopsBL.DeleteShop(x));
                      }
                      catch (Exception e)
                      {
                          ErrorMassage = e.Message;
                          HasError = true;
                      }
                  },
                  x => { return SelectedShop != null && !HasError; }, true
                  );
            initData();
        }

        private async void initData()
        {
            try
            {
                Loading = true;
                Shops = new ObservableCollection<Shop>(await Task.Run(() => shopsBL.GetShops()));
            }catch(Exception e)
            {
                ErrorMassage = e.Message;
                HasError = true;
            }
            finally
            {
                Loading = false;
            }
        }

        async Task IShop.Add(Shop shop)
        {
            ShopsBL shopsLogic = new ShopsBL();
            await shopsLogic.AddShop(shop);
        }

        async Task IShop.Update(Shop shop)
        {
            ShopsBL shopsLogic = new ShopsBL();
            await shopsLogic.UpdateShop(shop);
        }

        void IShop.AddToView(Shop shop)
        {
            Shops.Add(shop);
        }

        void IShop.UpdateView()
        {
            initData();
        }

        void IShop.Close()
        {
            Main.HideDialog();
        }

        private Shop _selectedShop = null;
        public Shop SelectedShop
        {
            get
            {
                return _selectedShop;
            }
            set
            {
                if (_selectedShop == value)
                {
                    return;
                }
                _selectedShop = value;
                RaisePropertyChanged(() => SelectedShop);
                DeleteShopCommand.RaiseCanExecuteChanged();
            }

        }

        private ObservableCollection<Shop> _shops = null;
        public ObservableCollection<Shop> Shops
        {
            get
            {
                return _shops;
            }
            set
            {
                if (_shops == value)
                {
                    return;
                }
                _shops = value;
                RaisePropertyChanged("Shops");
            }
        }

        private List<IceCream> _iceCreams = null;
        public List<IceCream> IceCreams
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
                RaisePropertyChanged("IceCreams");
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
            }
        }

        private bool _hasError = false;
        public bool HasError
        {
            get
            {
                return _hasError;
            }
            set
            {
                if (_hasError == value)
                {
                    return;
                }
                _hasError = value;
                RaisePropertyChanged("ErrorMassageVisability");
                AddShopCommand.RaiseCanExecuteChanged();
            }
        }


    }
}
