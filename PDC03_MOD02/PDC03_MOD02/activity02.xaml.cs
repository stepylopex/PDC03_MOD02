using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        public activity02()
        {
            InitializeComponent();
        }

        void OnSlideValueChanged(object sender, ValueChangedEventArgs args)
        {
            valuelabel.Text = args.NewValue.ToString("F3");
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!", 
                "The button labeled '" + button.Text + "' has been clicked", "OK");
        }
    }
}