using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {

            ImageButton smert;
            ImageButton storm;
            ImageButton inq;
            ImageButton ten;
            ImageButton soldat;


            smert = new ImageButton
            {
                Source = "smert.jpg"
            };
            smert.Clicked += Vvv_Clicked;
            var Sith = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Штурмовик смерти",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },
                    }
                }
            };



            storm = new ImageButton
            {
                Source = "storm.jpg"


            };
            storm.Clicked += Ppp_Clicked;
            var nSith = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Штурмовик",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },

                    }
                }
            };
            inq = new ImageButton
            {
                Source = "inq.jpg"


            };
            inq.Clicked += Pulll_Clicked;

            var luz = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Штурмовик Чистильщик",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },

                }
                }
            };

            soldat = new ImageButton
            {
                Source = "soldat.jpg"


            };
            soldat.Clicked += Lilit_Clicked;


            var lilith = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Тёмный солдат",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },

                }
                }
            };

            ten = new ImageButton
            {
                Source = "ten.jpg"


            };
            ten.Clicked += Korolik_Clicked;

            var koroll = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Штурмовик тень",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },

                }
                }
            };

            Children.Add(Sith);
            Children.Add(nSith);
            Children.Add(luz);
            Children.Add(koroll);
            Children.Add(lilith);

        }

        private async void Lilit_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://starwars.fandom.com/ru/wiki/%D0%A2%D1%91%D0%BC%D0%BD%D1%8B%D0%B9_%D1%81%D0%BE%D0%BB%D0%B4%D0%B0%D1%82", BrowserLaunchMode.SystemPreferred);
        }

        private async void Korolik_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://starwars.fandom.com/ru/wiki/%D0%A8%D1%82%D1%83%D1%80%D0%BC%D0%BE%D0%B2%D0%B8%D0%BA-%D1%82%D0%B5%D0%BD%D1%8C", BrowserLaunchMode.SystemPreferred);
        }

        private async void Vvv_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://starwars.fandom.com/ru/wiki/%D0%A8%D1%82%D1%83%D1%80%D0%BC%D0%BE%D0%B2%D0%B8%D0%BA_%D1%81%D0%BC%D0%B5%D1%80%D1%82%D0%B8", BrowserLaunchMode.SystemPreferred);
        }

        private async void Ppp_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://starwars.fandom.com/ru/wiki/%D0%A8%D1%82%D1%83%D1%80%D0%BC%D0%BE%D0%B2%D0%B8%D0%BA", BrowserLaunchMode.SystemPreferred);
        }

        private async void Pulll_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://starwars.fandom.com/ru/wiki/%D0%A8%D1%82%D1%83%D1%80%D0%BC%D0%BE%D0%B2%D0%B8%D0%BA-%D0%BE%D1%85%D0%BE%D1%82%D0%BD%D0%B8%D0%BA/%D0%9A%D0%B0%D0%BD%D0%BE%D0%BD", BrowserLaunchMode.SystemPreferred);
        }
    }
};
