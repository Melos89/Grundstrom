using Grundstrom.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Grundstrom.Pages.PersonalPages
{
    class HakanFrankPage : ContentPage
    {
        Button PhoneButton;
        public HakanFrankPage()
        {
            
            PhoneButton = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "040-419592",
                TextColor = Color.Navy,
                BackgroundColor = Color.White,
                BorderColor = Color.Navy,
                BorderRadius = 20,
                BorderWidth = 2,
            };
            PhoneButton.Clicked += OnPhoneTapped;

            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Children =
                {
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Text = "Håkan Frank",
                        TextColor = Color.Navy,
                    },
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Text = "Produktionschef",
                        TextColor = Color.Navy,
                    },
                    PhoneButton,
                },
            };
        }
        public async void OnPhoneTapped(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (await this.DisplayAlert(
                             "Håkan Frank",
                             "Call " + btn.Text + "?",
                             "Yes",
                             "No"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                {
                    dialer.Dial(btn.Text);
                }
            }
        }
    }
}
