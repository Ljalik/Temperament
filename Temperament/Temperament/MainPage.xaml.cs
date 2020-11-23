using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var stormContedPage = new ContentPage //nimetus
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Штурмовик",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new Image
                       { Source = "storm.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            var smertContedPage = new ContentPage //nimetus
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Штурмовик Смерти",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new Image
                       { Source = "smert.jpg",
                        WidthRequest = 500,
                        HeightRequest = 500,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            var tenContedPage = new ContentPage //nimetus
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Штурмовик-тень",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new Image
                       { Source = "Ten.jpg",
                        WidthRequest = 500,
                        HeightRequest = 500,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            var inqContedPage = new ContentPage //nimetus
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Штурмовик-охотник",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new Image
                       { Source = "inq.jpg",
                        WidthRequest = 500,
                        HeightRequest = 500,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            var solContedPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Тёмный солдат",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new Image
                       { Source = "soldat.jpg",
                        WidthRequest = 500,
                        HeightRequest = 500,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            var szikContedPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                   {
                       new Label
                       {
                           Text = "Штурмовик Сжигатель",//tekst
                           FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                           HorizontalOptions = LayoutOptions.Center
                       },
                       new Image
                       { Source = "szik.png",
                        WidthRequest = 500,
                        HeightRequest = 500,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                   }
                }
            };
            Children.Add(solContedPage);
            Children.Add(szikContedPage);
            Children.Add(inqContedPage);
            Children.Add(tenContedPage);
            Children.Add(smertContedPage);
            Children.Add(stormContedPage);
        }
    }
}
