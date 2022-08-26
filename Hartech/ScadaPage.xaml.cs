
using Hartech.MVVM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hartech
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScadaPage : ContentPage
    {
        private string tempturl = "https://hartech.i4connected.cloud/api/apps/";
        public static string url = "https://www.google.";




        public ScadaPage()
        {
            InitializeComponent();

            var mc = new VMCode();

            webView.Source = tempturl + mc.CustomerCode;

            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await progress.ProgressTo(0.9, 900, Easing.SpringIn);

        }

        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            progress.IsVisible = true;
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            progress.IsVisible = false;
        }
    }
}