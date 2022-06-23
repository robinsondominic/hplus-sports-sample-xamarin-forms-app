using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HPlusSports
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AllProduct());
        }

        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }

        private void Contact_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactUs());
        }
    }
}
