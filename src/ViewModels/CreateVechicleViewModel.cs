using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;

namespace MyDriving.ViewModels
{
    public class CreateVechicleViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public string Make { get; set; }

        public string Model { get; set; }

        public int YearOfManufacture { get; set; }

        public int Mileage { get; set; }

        public RelayCommand AddPhotoCommand { get; }

        public RelayCommand SaveCommand { get; }

        public RelayCommand CancelCommand { get; }

        public CreateVechicleViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            AddPhotoCommand = new RelayCommand(() => 
            {
                //TODO: Add proper implementation for camera handling
                throw new NotImplementedException();
            });

            CancelCommand = new RelayCommand(() => 
            {
                //TODO: Use NavigationService to navigate back to prev page
                navigationService.NavigateTo("MainPage");
            });

            SaveCommand = new RelayCommand(() => 
            {
                var entity = ToModel();
                Data.AppDbContext.Instance.Vehicles.Add(entity);
                Data.AppDbContext.Instance.SaveChanges();

                //TODO: Navigate to main page when save is success
                navigationService.NavigateTo("MainPage");
            });
        }

        private Models.Vehicle ToModel()
        {
            return new Models.Vehicle
            {
                Make = this.Make,
                Model = this.Model,
                ProductionYear = this.YearOfManufacture,
                Mileage = this.Mileage
            };
        }
    }
}