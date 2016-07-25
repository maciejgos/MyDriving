using GalaSoft.MvvmLight;

namespace MyDriving.ViewModels
{
    public class CreateVechicleViewModel : ViewModelBase
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int YearOfManufacture { get; set; }

        public int Mileage { get; set; }
    }
}
