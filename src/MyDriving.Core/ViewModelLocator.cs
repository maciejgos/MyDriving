using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using MyDriving.Core.ViewModels;

namespace MyDriving.Core
{
    public class ViewModelLocator
    {
        public AppShellViewModel AppShellViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AppShellViewModel>();
            }
        }

        public ProfilePageViewModel ProfilePageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProfilePageViewModel>();
            }
        }

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<AppShellViewModel>();
            SimpleIoc.Default.Register<ProfilePageViewModel>();
        }
    }
}
