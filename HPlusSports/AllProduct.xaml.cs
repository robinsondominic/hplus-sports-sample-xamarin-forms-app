using HPlusSports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllProduct : ContentPage
    {
        public AllProduct()
        {
            InitializeComponent();
        }

        public void Item_Selected(object sender, SelectionChangedEventArgs e) // Added Code
        {
            Services.Product product = e.CurrentSelection.First() as Services.Product;
            Navigation.PushAsync(new ProductDetail(product));
        }

        protected override async void OnAppearing() // Added Code
        {
            base.OnAppearing();
            var products = await ProductService.GetProductsAsync();
            BindingContext = products;
        }

    }
}