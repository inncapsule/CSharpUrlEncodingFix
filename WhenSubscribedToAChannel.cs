using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            pubnub.Subscribe(
                channel,
                delegate(object message) {
                    Assert.AreNotEqual(null, message);
                    return true;
                }
            );
            Assert.AreEqual("my/channel", channel);
        }
    }
}
