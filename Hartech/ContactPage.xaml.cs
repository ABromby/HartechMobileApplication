using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hartech
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Email", "Send email", "OK");
            await Launcher.OpenAsync(new Uri("mailto://enquires@hartechautomaion.com"));
        }

        private async void Twitter_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://twitter.com/hartechgroup?lang=en-gb"));
        }

        private async void Linkedin_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://www.linkedin.com/company/hartech-automation-limited/"));
        }

        private async void Phone_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("tel:+441913389080"));
        }

        private async void Youtube_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://www.youtube.com/channel/UCe9rX4ORoZkO7UiVU28XfsA?view_as=subscriber"));
        }
    }
}