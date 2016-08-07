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

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<AppShellViewModel>();
        }
    }
}
