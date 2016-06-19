using Foundation;
using Grundstrom.iOS;
using Grundstrom.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(PhoneDialer))]
namespace Grundstrom.iOS
{
    
    public class PhoneDialer : IDialer
    {
        public PhoneDialer()
        {

        }
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}
