using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyDriving.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Repositories.VehicleRepository repository = new Repositories.VehicleRepository();

        public IEnumerable<Models.Vehicle> Vehicles
        {
            get
            {
                return repository.GetAll();
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AddVehicle_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateVehicle));
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var obj = e.ClickedItem as Models.Vehicle;
            Frame.Navigate(typeof(DetailsPage), obj, new Windows.UI.Xaml.Media.Animation.SlideNavigationTransitionInfo());
        }
    }
}
