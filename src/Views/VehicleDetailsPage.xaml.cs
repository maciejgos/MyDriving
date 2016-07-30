using Microsoft.Practices.ServiceLocation;
using MyDriving.ViewModels;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyDriving.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VehicleDetailsPage : Page
    {
        public VehicleDetailsPage()
        {
            this.InitializeComponent();

            SystemNavigationManager.GetForCurrentView().BackRequested += DetailsPage_BackRequested;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var vm = ServiceLocator.Current.GetInstance<VehicleDetailsPageViewModel>();
            vm.Vehicle = e.Parameter as Models.Vehicle;

            base.OnNavigatedTo(e);
        }

        private void DetailsPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                frame.GoBack();
                e.Handled = true;
            }
        }
    }
}
