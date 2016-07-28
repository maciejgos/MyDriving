using GalaSoft.MvvmLight.Views;
using MyDriving.Views;

namespace MyDriving.Extensions
{
    public static class NavigationServiceExtension
    {
        public static void ConfigureRoutes(this NavigationService service)
        {
            service.Configure(Routes.MainPage, typeof(MainPage));
            service.Configure(Routes.CreateVehiclePage, typeof(CreateVehiclePage));
        }
    }
}
