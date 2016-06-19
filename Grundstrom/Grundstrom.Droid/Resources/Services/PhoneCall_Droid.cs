using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Grundstrom.Resources;

namespace Grundstrom.Droid.Services
{
    class PhoneCall_Droid : IDial
    {
        public void Dial(string phoneNumber)
        {
            try
            {
                var uri = Android.Net.Uri.Parse(string.Format("tel:{0}",phoneNumber));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}