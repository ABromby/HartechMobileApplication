using Xamarin.Forms;
using Xamarin.Essentials;
using Hartech.MVVM.Model;

namespace Hartech
{
    public partial class App : Application
    {


        public static string UserCode { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {
            MainPage = new NavigationPage(new HomePage());
        }
    }
}
