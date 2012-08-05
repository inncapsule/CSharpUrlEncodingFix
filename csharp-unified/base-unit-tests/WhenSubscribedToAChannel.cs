using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace PubNub_Messaging.Tests
{
    [TestClass]
    public class WhenSubscribedToAChannel
    {
        [TestMethod]
        public void ThenItShouldReturnReceivedMessage()
        {
            Pubnub pubnub = new Pubnub(
                "demo",
                "demo",
                "",
                false
            );
            string channel = "my/channel";

            pubnub.PropertyChanged += new PropertyChangedEventHandler(Pubnub_PropertyChanged);

            pubnub.subscribe(channel);
        }

        static void Pubnub_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Dictionary<string, object> _message = (Dictionary<string, object>)(((Pubnub)sender).ReturnMessage);
            Assert.IsNotNull(_message["text"]);
        }
    }
}
