using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SplunkHelloWorld.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main (string[] args)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => {
                return true;
            };

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main (args, null, "AppDelegate");
        }
    }
}

