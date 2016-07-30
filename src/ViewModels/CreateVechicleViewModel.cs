using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using MyDriving.Core.Repositories;
using MyDriving.Models;
using System;

namespace MyDriving.ViewModels
{
    public class CreateVechicleViewModel : ViewModelBase
    {
        private readonly IRepository<Vehicle> _repository;
        private readonly INavigationService _navigationService;
        private readonly Vehicle _entity;

        public Vehicle Vehicle
        {
            get
            {
                return _entity;
            }
        }

        public RelayCommand AddPhotoCommand { get; }

        public RelayCommand SaveCommand { get; }

        public RelayCommand CancelCommand { get; }

        public CreateVechicleViewModel(INavigationService navigationService, IRepository<Vehicle> repository)
        {
            _navigationService = navigationService;
            _repository = repository;
            _entity = new Vehicle();

            AddPhotoCommand = new RelayCommand(OnAddPhotoCommand);
            SaveCommand = new RelayCommand(OnSaveCommand);
            CancelCommand = new RelayCommand(OnCancelCommand);
        }

        private void OnCancelCommand()
        {
            _navigationService.NavigateTo(Routes.MainPage);
        }

        private void OnSaveCommand()
        {
            _repository.Add(_entity);
            _navigationService.NavigateTo(Routes.MainPage);
        }

        private void OnAddPhotoCommand()
        {
            throw new NotImplementedException();
        }
    }
}