using Grundstrom.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Grundstrom
{
    public class App : Application
    {
        NavigationPage navigator;
        Button OrderButton;
        Button ContactButton;
        Button MeasuringButton;
        Button ProductsButton;
        Label TitleLabel;
        Image logo;

        public App()
        {
            
            CreateControls();
            AddEvents();
            // The root page of your application

            #region firstPage
            var firstPage = new ContentPage
            {
                Icon = "Grundstromlogo.png",
                BackgroundImage = "LommaAB.png",
            Content = new StackLayout
                {

                    BackgroundColor = Color.White,
                    Padding = 30,
                    Spacing = 10,

                    Children =
                {
                    TitleLabel,
                    OrderButton,
                    ContactButton,
                    MeasuringButton,
                    ProductsButton,
                    new Label
                    {
                        Text = "Under konstruktion!",
                        TextColor = Color.Red,
                        HorizontalOptions = LayoutOptions.Center,
                    }
                }
                }

            };
            #endregion
            navigator = new NavigationPage(firstPage);
            MainPage = navigator;
        }

        private void AddEvents()
        {
            OrderButton.Clicked += ChangePage;
            ContactButton.Clicked += ChangePage;
            //MeasuringButton;
            //ProductsButton;
        }

        private void ChangePage(object sender, EventArgs e)
        {
            var btn = sender as Button;
            switch (btn.Text)
            {
                case "Beställnings guiden":
                    // DependencyService.Get<IPdfCreator>().ShowPdfFile();
                    //if (Device.OS == TargetPlatform.iOS)
                    //{
                    //    navigator.PushAsync(new PdfWebView(), true);
                    //}
                    //else
                    //{
                    //    navigator.PushAsync(new PdfPage(), true);
                    //}
                    navigator.PushAsync(new PdfPage(), true);
                    break;
                case "Kontakter":
                    navigator.PushAsync(new RootPage(),true);
                    break;
                default:
                    break;
            }
        }

        private void CreateControls()
        {

            TitleLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Grundström",
                FontSize = 40,
                TextColor = Color.Navy,
                BackgroundColor = Color.White,
            };
            OrderButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                Text = "Beställnings guiden",
                ClassId = "OrderButton",
                TextColor = Color.Navy,
                BorderColor = Color.Navy,
                BorderRadius = 35,
                BackgroundColor = Color.White,
                BorderWidth = 3,
            };
            ContactButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 150,
                Text = "Kontakter",
                ClassId = "Contacts",
                TextColor = Color.Navy,
                BorderColor = Color.Navy,
                BorderRadius = 35,
                BackgroundColor = Color.White,
                BorderWidth = 3,
            };
            MeasuringButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 150,
                TextColor = Color.Navy,
                BorderColor = Color.Navy,
                Text = "Mätinstrument",
                BorderRadius = 35,
                BackgroundColor = Color.White,
                BorderWidth = 3,
                IsEnabled = false,
                IsVisible = false,
            };
            ProductsButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 150,
                TextColor = Color.Navy,
                BorderColor = Color.Navy,
                Text = "Produkter",
                BorderRadius = 35,
                BackgroundColor = Color.White,
                BorderWidth = 3,
                IsEnabled = false,
                IsVisible = false,
            };
            logo = new Image
            {
                Source = "Grundstromlogo.png",
                HorizontalOptions = LayoutOptions.Center,
            };
        }
        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
