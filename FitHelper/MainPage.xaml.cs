using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitHelper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Spina());
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }
        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exit());
        }

    }
}
