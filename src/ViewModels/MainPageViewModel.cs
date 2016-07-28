using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using MyDriving.Core.Repositories;
using MyDriving.Models;
using System.Collections.ObjectModel;

namespace MyDriving.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IRepository<Vehicle> _repository;
        private readonly INavigationService _navigationService;

        public ObservableCollection<Vehicle> Vehicles
        {
            get
            {
                var result = _repository.GetAll();
                return new ObservableCollection<Vehicle>(result);
            }
        }

        public RelayCommand AddVehicleCommand { get; }

        public MainPageViewModel(INavigationService navigationService, IRepository<Vehicle> repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            AddVehicleCommand = AddVehicleCommand ?? new RelayCommand(() => _navigationService.NavigateTo("CreateVehiclePage"));
        }
    }
}
