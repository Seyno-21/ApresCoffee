using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApresCoffeeV4.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void espressoPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new espressoPage());
        }

        private async void hotDrinksPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hotDrinksPage());
        }

        private async void coldDrinksPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new coldDrinksPage());
        }

        private async void quickBitesPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new foodPage());
        }
    }
}