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
using Grundstrom.Droid;
using Java.IO;

[assembly: Dependency(typeof(PdfCreatorAndroid))]
namespace Grundstrom.Droid
{
    public class PdfCreatorAndroid : IPdfCreator
    {

        public void ShowPdfFile()
        {
            var fileLocation = "/sdcard/Template.pdf";
            var file = new File(fileLocation);

            if (!file.Exists())
                return;

            var intent = DisplayPdf(file);
            Forms.Context.StartActivity(intent);
        }

        public Intent DisplayPdf(File file)
        {
            var intent = new Intent(Intent.ActionView);
            var filepath = Android.Net.Uri.FromFile(file);
            intent.SetDataAndType(filepath, "application/pdf");
            intent.SetFlags(ActivityFlags.ClearTop);
            return intent;
        }
    }
}