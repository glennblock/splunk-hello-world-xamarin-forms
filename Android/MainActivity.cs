using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Net;

using Xamarin.Forms.Platform.Android;


namespace SplunkHelloWorld.Android
{
    [Activity (Label = "splunk-hello-world-xamarin-forms.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => {
                return true;
            };

            Xamarin.Forms.Forms.Init (this, bundle);

            SetPage (App.GetMainPage ());
        }
    }
}

