using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Grundstrom.Droid
{
	[Activity (Label = "Grundström", Icon = "@drawable/icon", Theme = "@android:style/Theme.Holo.Light", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{

			base.OnCreate (bundle);
            var obj = new PhoneDialer();
            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Grundstrom.App ());
		}
	}
}

