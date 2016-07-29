using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using MyDriving.Core.Repositories;
using MyDriving.Models;
using System;

namespace MyDriving.ViewModels
{
    public class VehicleDetailsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IRepository<Vehicle> _repository;

        public Vehicle Vehicle { get; set; }

        public RelayCommand SaveCommand { get; }

        public RelayCommand RefuelCommand { get; }

        public RelayCommand CancelCommand { get; }

        public VehicleDetailsPageViewModel(INavigationService navigationService, IRepository<Vehicle> repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            SaveCommand = new RelayCommand(OnSaveCommand);
            RefuelCommand = new RelayCommand(OnRefuelCommand);
            CancelCommand = new RelayCommand(OnCancelCommand);

            Messenger.Default.Register<NotificationMessage<Vehicle>>(this, Tokens.VehicleNotificationMessage, OnNotificationReceive);
        }

        private void OnNotificationReceive(NotificationMessage<Vehicle> message)
        {
            if (message == null || message.Content == null)
                throw new InvalidOperationException("Notification message or it's content cannot be null.");
            Vehicle = message?.Content;
        }

        private void OnCancelCommand()
        {
            _navigationService.NavigateTo(Routes.MainPage);
        }

        private void OnRefuelCommand()
        {
            throw new NotImplementedException();
        }

        private void OnSaveCommand()
        {
            _repository.Update(Vehicle);
            _navigationService.NavigateTo(Routes.MainPage);
        }
    }
}
