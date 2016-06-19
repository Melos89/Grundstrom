using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Grundstrom.Pages
{
   public class PdfPage : ContentPage
    {
        public PdfPage()
        {
                Padding = new Thickness(0, 20, 0, 0);
                Content = new StackLayout
                {

                    Children =
                            {
                                new CustomPDF
                                {
                                    Uri = "BESTALLNINGSGUIDE.pdf",
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                    VerticalOptions = LayoutOptions.FillAndExpand
                                },
                            }
                };
        }
    }
}
