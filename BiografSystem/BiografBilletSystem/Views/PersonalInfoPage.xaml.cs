using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BiografBilletSystem.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonalInfoPage : Page
    {
        public PersonalInfoPage()
        {
            this.InitializeComponent();
        }

        public void Button_navigation_kvittering(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(KvitteringPage), null);
        }
        public void Button_navigation_tilbage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SalPage), null);
        }
    }
}
