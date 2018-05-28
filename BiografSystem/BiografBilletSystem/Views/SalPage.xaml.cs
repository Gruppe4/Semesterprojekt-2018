using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using BiografBilletSystem.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BiografBilletSystem.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SalPage : Page
    {
        public SalPage()
        {
            this.InitializeComponent();
        }
        public void Button_navigation_back(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
        public void Button_navigation_reserver(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PersonalInfoPage), new RoutedEventArgs());
        }
    }
}
