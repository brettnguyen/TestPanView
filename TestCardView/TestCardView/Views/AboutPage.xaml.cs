using System;
using System.ComponentModel;
using TestCardView.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCardView.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }
    }
}
