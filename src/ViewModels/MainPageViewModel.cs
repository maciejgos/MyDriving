using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using MyDriving.Models;
using MyDriving.Repositories;
using System.Collections.ObjectModel;

namespace MyDriving.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IRepository<Vehicle> _repository;
        private readonly INavigationService _navigationService;

        public ObservableCollection<Vehicle> Vehicles { get; }

        public RelayCommand AddVehicleCommand { get; }

        public MainPageViewModel(INavigationService navigationService, IRepository<Vehicle> repository)
        {
            this._navigationService = navigationService;
            this._repository = repository;

            var result = this._repository.GetAll();
            Vehicles = Vehicles ?? new ObservableCollection<Vehicle>(result);

            AddVehicleCommand = AddVehicleCommand ?? new RelayCommand(() => this._navigationService.NavigateTo("CreateVehiclePage"));
        }
    }
}
