using StandardPCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DjonTraore
{
    public partial class MainPage : ContentPage
    {

        public string MainText { get; private set; } = "Hello Xamarin";

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = this;

            var tapGesture = new TapGestureRecognizer();
            tapGesture.Command = new Command(() => {

                var muezzin = new Muezzin();
                DisplayAlert("Alert", " It is currently: " + muezzin.GetCurrentTime(), "Ok");
            });
            bxvwColor.GestureRecognizers.Add(tapGesture);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var random = new Random();

            var muezzin = new Muezzin();
            var counter = 0;

            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                MainText = muezzin.Callout() + "," + counter++;
                OnPropertyChanged(nameof(MainText));
                var val = random.Next(0, 3);
                bxvwColor.Color = val == 0 ? Color.Accent : Color.Fuchsia;
                return true;
            });
        }
    }
}
