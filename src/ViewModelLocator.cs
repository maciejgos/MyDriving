﻿using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MyDriving.Models;
using MyDriving.Core.Repositories;
using MyDriving.ViewModels;
using System.Collections.Generic;
using MyDriving.Core.Calculators;
using MyDriving.Extensions;

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

        public VehicleDetailsPageViewModel VehicleDetailsPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<VehicleDetailsPageViewModel>();
            }
        }

        public RefuelPageViewModel RefuelPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RefuelPageViewModel>();
            }
        }

        static ViewModelLocator()
        {
            var navigationService = new NavigationService();
            navigationService.ConfigureRoutes();

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            SimpleIoc.Default.Register<IRepository<Vehicle>>(() => new VehicleRepository());
            SimpleIoc.Default.Register<ICalculation<IEnumerable<Refuel>,decimal>>(() => new FuelConsumptionCalculationEngine());

            SimpleIoc.Default.Register<CreateVechicleViewModel>();
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<VehicleDetailsPageViewModel>();
            SimpleIoc.Default.Register<RefuelPageViewModel>();
        }
    }
}
