using System.ServiceModel;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using ViewModel.App.Implementation;

namespace BiografBilletSystem.ViewModels
{
    class MainViewModel 
    {
        public object Server { get; private set; }

        protected void Videre_Click(object sender, System.EventArgs e)
        {
            Server.Transfer("SalPage.xaml", true);
        }
    }
}
