using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using MyDriving.ViewModels;
using MyDriving.Views;

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

        static ViewModelLocator()
        {
            var navigationService = new NavigationService();
            navigationService.Configure("MainPage", typeof(MainPage));

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            SimpleIoc.Default.Register<CreateVechicleViewModel>();
        }
    }
}
