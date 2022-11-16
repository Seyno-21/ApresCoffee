using ApresCoffeeV4.ViewModels;
using ApresCoffeeV4.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ApresCoffeeV4
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
