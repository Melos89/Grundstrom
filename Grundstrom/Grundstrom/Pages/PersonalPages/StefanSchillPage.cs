using Grundstrom.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Grundstrom.Pages.PersonalPages
{
    class StefanSchillPage : ContentPage
    {
        Button PhoneButton;
        public StefanSchillPage()
        {
            PhoneButton = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "040-419594",
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
                        Text = "Stefan Schill",
                        TextColor = Color.Navy,
                    },
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Text = "Marknadschef",
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
                             "Stefan Schill",
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
