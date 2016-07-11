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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyDriving.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddFuellingPage : Page
    {
        Models.Vehicle model;

        public AddFuellingPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            model = e.Parameter as Models.Vehicle;
            base.OnNavigatedTo(e);
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Models.Fuelling newFuelling = new Models.Fuelling { Liters = 10, Mileage = 200000, Price = 100.00m, PricePerLiter = 10.00m };
            model.Fuellings.Add(newFuelling);

            Data.AppDbContext.Instance.Fuellings.Add(newFuelling);
            await Data.AppDbContext.Instance.SaveChangesAsync();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
