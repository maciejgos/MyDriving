using Microsoft.Practices.ServiceLocation;
using MyDriving.Models;
using MyDriving.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyDriving.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddFuellingPage : Page
    {
        public AddFuellingPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var vm = ServiceLocator.Current.GetInstance<RefuelPageViewModel>();
            vm.Vehicle = e.Parameter as Vehicle;

            base.OnNavigatedTo(e);
        }
    }
}
