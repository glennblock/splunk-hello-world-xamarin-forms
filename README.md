splunk-hello-world-xamarin-forms
================================
Super simple hello world using the [Splunk C# SDK] (http://dev.splunk.com/view/csharp-sdk/SP-CAAAEPK) in Xamarin Forms.

# Pre-requisites
* To use the Splunk SDK on Xamarin Forms currently requires our daily build of our SDK off of MyGet. The current source includes the packages. If you want to develop with them though, add our MyGet feed to your package sources: https://splunk.myget.org/F/splunk-sdk-csharp-pcl/. This is temporary as we will be publishing 2.1 soon.
* You need a Splunk instance which you can access.

# Setup
In the App.cs file change the logon settings to your Splunk Server host, port and credentials.
