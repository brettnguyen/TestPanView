using TestCardView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TestCardView.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private ObservableCollection<TestImage> items;
        public ObservableCollection<TestImage> Items
        {
            get { return items; }
            set
            {

                items = value;
                OnPropertyChanged();
            }

        }
        private TestImage currentItem;
        public TestImage CurrentItem
        {
            get { return currentItem; }
            set { SetProperty(ref currentItem, value); }
        }

        public AboutViewModel()
        {
            Items = new ObservableCollection<TestImage>()
            {

           new TestImage(){
               PostImage = "Xamarin_logo.png"
               },
           new TestImage(){
               PostImage = "Xamarin_logo.png"
           },

            };
        }

       
    }
}
