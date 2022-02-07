using System;
using System.Collections.Generic;
using TestCardView.ViewModels;
using TestCardView.Views;
using Xamarin.Forms;

namespace TestCardView
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
