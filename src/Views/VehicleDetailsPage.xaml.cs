using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class VehicleDetailsPage : Page
    {
        Models.Vehicle model;

        public IEnumerable<Models.Refuel> Fuellings
        {
            get
            {
                return model.Fuellings;
            }
        }

        public VehicleDetailsPage()
        {
            this.InitializeComponent();

            SystemNavigationManager.GetForCurrentView().BackRequested += DetailsPage_BackRequested;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            model = e.Parameter as Models.Vehicle;
            var dialog = new Windows.UI.Popups.MessageDialog($"{model.Make} {model.Model}").ShowAsync();

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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddFullingButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddFuellingPage), model);
        }

        private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
