using ApresCoffeeV4.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ApresCoffeeV4.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}