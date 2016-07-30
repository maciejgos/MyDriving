using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using MyDriving.Core.Repositories;
using MyDriving.Models;
using System.Collections.Generic;
using System;

namespace MyDriving.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IRepository<Vehicle> _repository;
        private readonly INavigationService _navigationService;

        public IEnumerable<Vehicle> Vehicles
        {
            get
            {
                return _repository.GetAll();
            }
        }

        public RelayCommand AddVehicleCommand { get; }

        public RelayCommand<Vehicle> ShowDetailsPageCommand { get; }

        public RelayCommand SettingsCommand { get; }

        public MainPageViewModel(INavigationService navigationService, IRepository<Vehicle> repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            AddVehicleCommand = new RelayCommand(OnAddVehicleCommand);
            ShowDetailsPageCommand = new RelayCommand<Vehicle>(OnShowDetailsCommand);
            SettingsCommand = new RelayCommand(OnSettingsCommand);
        }

        private void OnSettingsCommand()
        {
            throw new NotImplementedException();
        }

        private void OnShowDetailsCommand(Vehicle vehicle)
        {
            _navigationService.NavigateTo(Routes.VehicleDetailsPage, vehicle);
        }

        private void OnAddVehicleCommand()
        {
            _navigationService.NavigateTo(Routes.CreateVehiclePage);
        }
    }
}
