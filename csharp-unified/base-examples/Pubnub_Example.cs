using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PubNub_Messaging
{
    public class Pubnub_Example
    {
        static public void Main()
        {
            Pubnub pubnub = new Pubnub(
            "demo",
            "demo",
            "",
            false
            );
            string channel = "my/channel";
            string message = "Pubnub API Usage Example";

            pubnub.PropertyChanged += new PropertyChangedEventHandler(Pubnub_PropertyChanged);

            Console.WriteLine("UUID -> " + pubnub.generateGUID());

            pubnub.publish(channel, message);

            pubnub.history(channel, 10);

            pubnub.time();

            pubnub.subscribe(channel);

            Console.ReadKey();
        }

        static void Pubnub_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "History":
                    foreach (object history_message in ((Pubnub)sender).History)
                    {
                        Console.WriteLine("History Message: ");
                        Dictionary<string, object> _messageHistory = (Dictionary<string, object>)(history_message);
                        Console.WriteLine(_messageHistory["text"]);
                    }
                    break;
                case "Publish":
                    Console.WriteLine(
                    "Publish Success: " + ((Pubnub)sender).Publish[0].ToString() +
                    "\nPublish Info: " + ((Pubnub)sender).Publish[1].ToString()
                    );
                    break;
                case "Time":
                    Console.WriteLine("Time:  " + ((Pubnub)sender).Time[0].ToString());
                    break;
                case "ReturnMessage":
                    Dictionary<string, object> _message = (Dictionary<string, object>)(((Pubnub)sender).ReturnMessage);
                    Console.WriteLine("Received Message -> '" + _message["text"] + "'");
                    break;
                default:
                    break;
            }
        }
    }
}
