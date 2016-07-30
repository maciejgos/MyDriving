using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyDriving.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var vm = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<ViewModels.MainPageViewModel>();
            vm.ShowDetailsPageCommand.Execute(e.ClickedItem);
        }
    }
}
