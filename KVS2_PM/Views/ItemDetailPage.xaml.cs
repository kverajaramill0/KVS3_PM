using KVS2_PM.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KVS2_PM.Views
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