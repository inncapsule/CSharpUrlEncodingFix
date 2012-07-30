using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PubNub_Messaging.Tests
{
    [TestClass]
    public class WhenAMessageIsPublished
    {
        [TestMethod]
        public void ThenItShouldReturnSuccessCodeAndInfo()
        {
            Pubnub pubnub = new Pubnub(
                "demo",
                "demo",
                "",
                false
            );
            string channel = "my/channel";
            List<object> info = pubnub.Publish(channel, "Hi");

            Assert.AreEqual(1, info[0]);
            Assert.AreEqual("Sent", info[1]);
        }
    }
}
