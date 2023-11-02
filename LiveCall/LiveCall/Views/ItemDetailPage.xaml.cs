using System.ComponentModel;
using Xamarin.Forms;
using LiveCall.ViewModels;

namespace LiveCall.Views
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
