using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using MyDriving.Core.Repositories;
using MyDriving.Models;
using System.Collections.Generic;

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

        public Vehicle SelectedItem { get; set; }

        public RelayCommand AddVehicleCommand { get; }

        public RelayCommand ShowDetailsPageCommand { get; }

        public RelayCommand SettingsCommand { get; }

        public MainPageViewModel(INavigationService navigationService, IRepository<Vehicle> repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            AddVehicleCommand = AddVehicleCommand ?? new RelayCommand(() => _navigationService.NavigateTo(Routes.CreateVehiclePage));

            ShowDetailsPageCommand = ShowDetailsPageCommand ?? new RelayCommand(() =>
            {
                var message = new NotificationMessage<Vehicle>(SelectedItem, string.Empty);

                Messenger.Default.Send(message, Tokens.VehicleNotificationMessage);
                _navigationService.NavigateTo(Routes.VehicleDetailsPage);
            });

            SettingsCommand = SettingsCommand ?? new RelayCommand(() => { throw new System.NotImplementedException(); });
        }
    }
}
