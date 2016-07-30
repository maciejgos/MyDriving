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

        public RelayCommand ChangePhotoCommand { get; }

        public RelayCommand SaveCommand { get; }

        public RelayCommand RefuelCommand { get; }

        public RelayCommand CancelCommand { get; }

        public VehicleDetailsPageViewModel(INavigationService navigationService, IRepository<Vehicle> repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            ChangePhotoCommand = new RelayCommand(OnChangePhotoCommand);
            SaveCommand = new RelayCommand(OnSaveCommand);
            RefuelCommand = new RelayCommand(OnRefuelCommand);
            CancelCommand = new RelayCommand(OnCancelCommand);
        }

        private void OnCancelCommand()
        {
            _navigationService.NavigateTo(Routes.MainPage);
        }

        private void OnRefuelCommand()
        {
            throw new NotImplementedException();
        }

        private void OnChangePhotoCommand()
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
