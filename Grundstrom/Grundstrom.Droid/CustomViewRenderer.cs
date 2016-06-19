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
using Xamarin.Forms;
using Grundstrom;
using Grundstrom.Droid;
using Xamarin.Forms.Platform.Android;
using System.Net;

[assembly: ExportRenderer(typeof(CustomPDF), typeof(CustomWebViewRenderer))]
namespace Grundstrom.Droid
{
    public class CustomWebViewRenderer : WebViewRenderer
    { 
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomPDF;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                Control.LoadUrl(string.Format("file:///android_asset/web/viewer.html?file={0}", string.Format("file:///android_asset/{0}", WebUtility.UrlEncode(customWebView.Uri))));
            }


        }
    }
}