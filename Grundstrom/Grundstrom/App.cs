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
        Image background;
        public App()
        {
            CreateControls();
            AddEvents();
            // The root page of the application
            var testPage = new MainPage();
            #region firstPage

            #region trying a relativelayout page
            RelativeLayout layout = CreatingRelativeLayoutPage();
            #endregion
            var firstPage = new ContentPage
            {
                Content = layout,
                //Content = new StackLayout
                //{

                //    BackgroundColor = Color.White,
                //    Padding = 30,
                //    Spacing = 10,

                //    Children =
                //{
                //    //TitleLabel,

                //    OrderButton,
                //    ContactButton,
                //    MeasuringButton,
                //    ProductsButton,
                //    new Label
                //    {
                //        Text = "Under konstruktion!",
                //        TextColor = Color.Red,
                //        HorizontalOptions = LayoutOptions.Center,
                //    }
                //}
                //}

            };
            #endregion




            navigator = new NavigationPage(firstPage);
            MainPage = navigator;
            //MainPage.BackgroundImage = "GrundstromiLommaAB.png";
            //Device.OnPlatform("Drawable/LommaAB.png", "Resources/LommaAB.png", "Assets/GrundstromiLommaAB.png");
        }

        private RelativeLayout CreatingRelativeLayoutPage()
        {
            var tempLayout = new RelativeLayout();
            Image img = new Image();
            img.Source = Device.OnPlatform(iOS: ImageSource.FromFile("Resources/lommaab.png"),
                                            Android: ImageSource.FromFile("lommaab.png"),
                                            WinPhone: ImageSource.FromFile("Assets/lommaab.png"));
            img.Aspect = Aspect.AspectFill;


            //Button OrderButton;
            //Button ContactButton;
            //Button MeasuringButton;
            //Button ProductsButton;
            tempLayout.Children.Add(img,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => { return parent.Width; }),
                Constraint.RelativeToParent((parent) => { return parent.Height; }));

            tempLayout.Children.Add(OrderButton,
                Constraint.RelativeToView(img,(Parent,sibling) => { return sibling.X + 50; }),
                Constraint.RelativeToView(img, (Parent, sibling) => { return sibling.Y + 20; }),
                Constraint.RelativeToParent((parent) => { return parent.Width * .5; }),
                Constraint.RelativeToParent((parent) => { return parent.Height * .2; }));

            tempLayout.Children.Add(ContactButton,
                Constraint.RelativeToView(img, (Parent, sibling) => { return sibling.X + 50; }),
                Constraint.RelativeToView(img, (Parent, sibling) => { return sibling.Y + 120; }),
                Constraint.RelativeToParent((parent) => { return parent.Width * .5; }),
                Constraint.RelativeToParent((parent) => { return parent.Height * .2; }));

            tempLayout.Children.Add(MeasuringButton,
                Constraint.RelativeToView(img, (Parent, sibling) => { return sibling.X + 50; }),
                Constraint.RelativeToView(img, (Parent, sibling) => { return sibling.Y + 220; }),
                Constraint.RelativeToParent((parent) => { return parent.Width * .5; }),
                Constraint.RelativeToParent((parent) => { return parent.Height * .2; }));

            tempLayout.Children.Add(ProductsButton,
                Constraint.RelativeToView(img, (Parent, sibling) => { return sibling.X + 50; }),
                Constraint.RelativeToView(img, (Parent, sibling) => { return sibling.Y + 320; }),
                Constraint.RelativeToParent((parent) => { return parent.Width * .5; }),
                Constraint.RelativeToParent((parent) => { return parent.Height * .2; }));


            return tempLayout;
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
                    navigator.PushAsync(new RootPage(), true);
                    break;
                default:
                    break;
            }
        }

        private void CreateControls()
        {
            background = new Image();
            background.Source = Device.OnPlatform(iOS: ImageSource.FromFile("Resources/lommaab.png"),
                                            Android: ImageSource.FromFile("lommaab.png"),
                                            WinPhone: ImageSource.FromFile("Assets/lommaab.png"));
            background.Aspect = Aspect.Fill;
            TitleLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Grundström",
                FontSize = 40,
                TextColor = Color.Navy,
                BackgroundColor = Color.Transparent,
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
                BackgroundColor = Color.Transparent,
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
                BackgroundColor = Color.Transparent,
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
                BackgroundColor = Color.Transparent,
                BorderWidth = 3,
                IsEnabled = false,
            };
            ProductsButton = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 150,
                TextColor = Color.Navy,
                BorderColor = Color.Navy,
                Text = "Produkter",
                BorderRadius = 35,
                BackgroundColor = Color.Transparent,
                BorderWidth = 3,
                IsEnabled = false,
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
