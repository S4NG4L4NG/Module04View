using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void AlertPop(object sender, EventArgs e)
        {
            await DisplayAlert("WARNING", "RETURN NOW!", "OK");
        }
        private async void textCell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextCell());
        }
        private async void imageCell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageCell());
        }
        private async void entryCell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryCell());
        }
        private async void switchCell(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchCell());
        }

    }
}
