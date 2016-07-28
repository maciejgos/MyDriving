using System;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MyDriving.Models;
using MyDriving.Core.Repositories;
using MyDriving.ViewModels;
using MyDriving.Views;

namespace MyDriving
{
    public class ViewModelLocator
    {
        public CreateVechicleViewModel CreateVehicleViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CreateVechicleViewModel>();
            }
        }

        public MainPageViewModel MainPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainPageViewModel>();
            }
        }

        static ViewModelLocator()
        {
            var navigationService = new NavigationService();
            navigationService.Configure("MainPage", typeof(MainPage));
            navigationService.Configure("CreateVehiclePage", typeof(CreateVehiclePage));

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            SimpleIoc.Default.Register<IRepository<Vehicle>>(() => new VehicleRepository());

            SimpleIoc.Default.Register<CreateVechicleViewModel>();
            SimpleIoc.Default.Register<MainPageViewModel>();
        }
    }
}
