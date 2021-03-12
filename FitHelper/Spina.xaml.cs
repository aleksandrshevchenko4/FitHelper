using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitHelper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Spina : ContentPage
    {
        public Spina()
        {
            InitializeComponent();
        }

        private async void phonesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((string)e.SelectedItem == "Упражнение 1")//выбранный элемент переводиться в стринг и сравниться то ли это выбратонно.
            {
                await Navigation.PushAsync(new spina1());//переход на старницу выбранного элемента.
            }
            if ((string)e.SelectedItem == "Упражнение 2")
            {
                await Navigation.PushAsync(new spina2());
            }
            if ((string)e.SelectedItem == "Упражнение 3")
            {
                await Navigation.PushAsync(new spina3());
            }
        }

        private void spinList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}