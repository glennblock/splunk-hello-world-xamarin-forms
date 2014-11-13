using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Splunk.Client;

namespace SplunkHelloWorld
{
    public class App
    {
        public static Page GetMainPage ()
        {    
            var listView = new ListView ();
            var events = new ObservableCollection<EventViewModel> ();
            listView.ItemsSource = events;

            listView.ItemTemplate = new DataTemplate (() => {
                var label = new Label();
                label.SetBinding(Label.TextProperty, new Binding("Text", BindingMode.OneWay, null, null, null));
                label.LineBreakMode = LineBreakMode.TailTruncation;
                return new ViewCell {
                    View = new ContentView {
                        Content=label
                    }
                };
            });

            var page = new ContentPage { 
                Content = listView,
                Padding = 20
            };

            listView.ItemTapped += (sender, e) => {
                var model = (EventViewModel)e.Item;
                page.DisplayAlert ("Splunk Search", model.Text, "OK", null);
            };

            page.Appearing += async (sender, e) => {
                var service = new Service (Scheme.Https, "localhost", 8089);
                await service.LogOnAsync ("admin", "changeme");
                var results = await service.ExportSearchResultsAsync ("search index = sample | head 10");
                foreach (var result in results) {
                    events.Add (new EventViewModel { Text = result.GetValue ("_raw").ToString () + "\n" });
                }
            };
            return page;
        }
    }

    public class EventViewModel {
        public string Text {get;set;}
    }
}

