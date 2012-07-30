using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PubNub_Messaging.Tests
{
    [TestClass]
    public class WhenGetRequestHistoryMessages
    {
        [TestMethod]
        public void ThenItShouldReturnHistoryMessages()
        {
            Pubnub pubnub = new Pubnub(
                "demo",
                "demo",
                "",
                false
            );
            string channel = "my/channel";

            List<object> history = pubnub.History(channel, 1);

            Assert.AreEqual(1, history.Count);
        }
    }
}
