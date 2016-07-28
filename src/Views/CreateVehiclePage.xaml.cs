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
    public sealed partial class CreateVehiclePage : Page
    {
        public CreateVehiclePage()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().BackRequested += CreateVehicle_BackRequested;
        }

        private void CreateVehicle_BackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                frame.GoBack();
                e.Handled = true;
            }
        }

        //private async void SaveButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //TODO: Validate input
        //    var entity = new Models.Vehicle
        //    {
        //        Make = TextBoxMake.Text,
        //        Model = TextBoxModel.Text,
        //        ProductionYear = int.Parse(TextBoxAge.Text),
        //        Mileage = int.Parse(TextBoxMileage.Text)
        //    };

        //    Data.AppDbContext.Instance.Vehicles.Add(entity);
        //    await Data.AppDbContext.Instance.SaveChangesAsync();

        //    Frame.GoBack();
        //}

        //private void CancelButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.GoBack();
        //}

        //private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
