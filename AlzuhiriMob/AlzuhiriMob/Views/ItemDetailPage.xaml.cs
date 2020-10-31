using System.ComponentModel;
using Xamarin.Forms;
using AlzuhiriMob.ViewModels;

namespace AlzuhiriMob.Views
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