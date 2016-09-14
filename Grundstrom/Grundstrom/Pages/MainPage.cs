using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Grundstrom.Pages
{
   public class MainPage : ContentPage
    {
        Button OrderButton;
        Button ContactButton;
        Button MeasuringButton;
        Button ProductsButton;
        Label TitleLabel;
        public MainPage()
        {
            CreateControls();

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children =
                {
                    new Image() {Source = FileImageSource.FromFile("Images/GrundstromiLommaAB.png") },
                    TitleLabel,
                    OrderButton,
                    ContactButton,
                    MeasuringButton,
                    ProductsButton,
                }
            };
        }
        private void CreateControls()
        {

            TitleLabel = new Label
            {
                Text = "Grundström",
            };
            OrderButton = new Button
            {
                Text = "Beställnings guide",
                ClassId = "OrderButton",

            };
            ContactButton = new Button
            {
                Text = "Kontakter",
                ClassId = "Contacts",
            };
            MeasuringButton = new Button
            {
                Text = "Mät instrument",
                IsEnabled = false,
            };
            ProductsButton = new Button
            {
                Text = "Produkter",
                IsEnabled = false,
            };

        }
    }
}
