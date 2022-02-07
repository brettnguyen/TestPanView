using System.ComponentModel;
using Xamarin.Forms;
using TestCardView.ViewModels;

namespace TestCardView.Views
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
