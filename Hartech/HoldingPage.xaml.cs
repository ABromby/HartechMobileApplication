using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hartech
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoldingPage : ContentPage
    {
        public HoldingPage()
        {
            InitializeComponent();
        }

        private async void ScadaButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(App.UserCode))
            {
                await DisplayAlert("No Customer Code", "Please enter your Unique code in the settings page", "Accept");
            }
            else
            {
                await Navigation.PushAsync(new ScadaPage());
            }
        }


        private async void PopUpButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(App.UserCode))
            {
                await DisplayAlert("No Customer Code", "Please enter your Unique code in the settings page", "Accept");
            }
            else
            {
                await DisplayAlert("URL", "your unique code is " + ScadaPage.url + App.UserCode, "Accept", "Cancel");
            }
        }
    }
}